using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CCaptureMockAPI.Swagger;
using CCaptureMockAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;


namespace CCaptureMockApi.Controllers
{
    [ApiController]
    [Route("ProcessDocument")]
    //[Authorize]
    public class DocumentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DocumentController(ApplicationDbContext context)
        {
            _context = context;
        }


        //[HttpPost("ConvertFileToBase64")]
        //public async Task<IActionResult> ConvertFileToBase64(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return BadRequest(new { error = "No file uploaded or file is empty." });

        //    try
        //    {
        //        using var memoryStream = new MemoryStream();
        //        await file.CopyToAsync(memoryStream);
        //        byte[] fileBytes = memoryStream.ToArray();
        //        string base64String = Convert.ToBase64String(fileBytes);

        //        return Ok(new
        //        {
        //            FileName = file.FileName,
        //            Base64String = base64String
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { error = "Internal server error", details = ex.Message });
        //    }
        //}


        [HttpPost("StartDocumentVerification")]
        public async Task<IActionResult> StartDocumentVerification(
        [FromHeader] string sourceSystem,
        [FromHeader] string channel,
        [FromHeader(Name = "interactionDate-Time")] string interactionDateTime,
        [FromHeader] string sessionID,
        [FromHeader] string messageID,
        [FromHeader] string userCode,
        [FromBody] DocumentRequest request)
        {
            if (request == null || request.Documents == null || request.Documents.Count == 0)
            {
                return BadRequest(new { errors = new { Documents = new List<string> { "Documents list cannot be empty." } } });
            }

            // Validate PageType only for "Allianz Transfers" batch class
            if (request.BatchClassName == "Allianz Transfers")
            {
                foreach (var doc in request.Documents)
                {
                    if (string.IsNullOrEmpty(doc.PageType))
                    {
                        return BadRequest(new { errors = new { PageType = "PageType is required for Allianz Transfers batch class." } });
                    }
                }
            }

            // Generate a new RequestGuid
            var requestGuid = Guid.NewGuid();

            // Serialize the request fields and documents into JSON strings
            var fieldsJson = JsonSerializer.Serialize(request.Fields);
            var documentsJson = JsonSerializer.Serialize(request.Documents);

            // Save the files from Base64 string
            var filePaths = new List<string>();
            var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            foreach (var doc in request.Documents)
            {
                if (string.IsNullOrEmpty(doc.Buffer))
                {
                    return BadRequest(new { errors = new { Documents = new List<string> { "Buffer (Base64 string) is required for each document." } } });
                }

                // Decode the Base64 string to byte array
                byte[] fileBytes = Convert.FromBase64String(doc.Buffer);

                // Extract the file extension and file name without extension
                string fileExtension = Path.GetExtension(doc.FileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(doc.FileName);

                // Ensure the file extension is valid
                if (string.IsNullOrEmpty(fileExtension))
                {
                    return BadRequest(new { errors = new { Documents = new List<string> { "File extension is missing or invalid." } } });
                }

                // Generate a unique file name while keeping the correct extension
                var uniqueFileName = $"{Guid.NewGuid()}_{fileNameWithoutExtension}{fileExtension}";

                // Set the file path
                var filePath = Path.Combine(uploadDirectory, uniqueFileName);

                // Save the decoded file to the server
                await System.IO.File.WriteAllBytesAsync(filePath, fileBytes);

                // Add the file path to the list for database storage
                filePaths.Add(filePath);
            }



            // Create a new document verification request object
            var verificationRequest = new DocumentVerificationRequest
            {
                RequestGuid = requestGuid,
                BatchClassName = request.BatchClassName,
                Fields = fieldsJson,
                Documents = documentsJson,
                FilePath = string.Join(";", filePaths),
                CreatedAt = DateTime.UtcNow
            };

            // Save the request to the database
            await _context.DocumentVerificationRequests.AddAsync(verificationRequest);
            await _context.SaveChangesAsync();

            // Simulate message queuing
            var message = JsonSerializer.Serialize(request);
            Console.WriteLine($"Simulated Queue Message: {message}");

            // Return the RequestGuid as part of the response
            return Ok(new { RequestGuid = requestGuid });
        }



        [HttpGet("ReadDocumentVerification")]
        public IActionResult ReadDocumentVerification(
            [FromHeader] string sourceSystem,
            [FromHeader] string channel,
            [FromHeader(Name = "interactionDate-Time")] string interactionDateTime,
            [FromHeader] string sessionID,
            [FromHeader] string messageID,
            [FromHeader] string userCode,
            [FromQuery] string requestGuid)
        {
            if (string.IsNullOrWhiteSpace(requestGuid))
                return BadRequest(new ErrorResponse { Code = "-1", Message = "Missing requestGuid" });

            return Ok(new
            {
                RequestGuid = requestGuid
            });
        }
    }
}