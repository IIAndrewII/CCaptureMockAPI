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
using Microsoft.AspNetCore.Authorization;


namespace CCaptureMockApi.Controllers
{
    [ApiController]
    [Route("ProcessDocument")]
    [Authorize]
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

            // Save a new entry in DocumentVerificationResponses with a constant ResponseJson
            var constantResponseJson = JsonSerializer.Serialize(new
            {
                Batch = new
                {
                        Id = 1234,
                        Name = "7758334c05f54e598f39f80fc3a8723dc531080867d64f8599131448a5697b02",
                        CreationDate = "2024-11-22T09:05:13.2311317+01:00",
                        CloseDate = "2024-11-22T09:05:16.8028944+01:00",
                        BatchClass = new { Name = "ALLIANZ" },
                        BatchFields = new[]
                        {
                            new { Name = "NAME_IN", Value = "ALESSANDRO", Confidence = 0 },
                            new { Name = "SURNAME_IN", Value = "GAIA", Confidence = 0 },
                            new { Name = "CF_IN", Value = "GAILSN70P09E463H", Confidence = 0 },
                            new { Name = "NAME_OUT", Value = "ALESSANDRO", Confidence = 1 },
                            new { Name = "SURNAME_OUT", Value = "GAIA", Confidence = 1 },
                            new { Name = "EXP_DATE_OUT", Value = "2028/11/28", Confidence = 0 }
                        },
                        Documents = new[]
                        {
                            new
                            {
                                Name = "pag1.png",
                                Pages = new[]
                                {
                                    new
                                    {
                                        FileName = "000001.png",
                                        PageTypes = new[] { new { Name = "CIE Fronte", Confidence = 0.95180047 } },
                                        Sections = (object)null
                                    }
                                },
                                DocumentClass = new { Name = "CIE" },
                                DocumentFields = Array.Empty<object>(),
                                Signatures = Array.Empty<object>()
                            },
                            new
                            {
                                Name = "pag2.png",
                                Pages = new[]
                                {
                                    new
                                    {
                                        FileName = "000002.png",
                                        PageTypes = new[] { new { Name = "CIE Retro", Confidence = 0.9265266 } },
                                        Sections = (object)null
                                    }
                                },
                                DocumentClass = new { Name = "CIE" },
                                DocumentFields = Array.Empty<object>(),
                                Signatures = Array.Empty<object>()
                            }
                        },
                        BatchStates = new[]
                        {
                            new { Value = "Start", TrackDate = "2024-11-22T09:05:13.0357384+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "Create", TrackDate = "2024-11-22T09:05:13.2311317+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "OCR", TrackDate = "2024-11-22T09:05:15.6735245+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "Expression Match", TrackDate = "2024-11-22T09:05:16.6689351+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "Classification Page Types", TrackDate = "2024-11-22T09:05:16.7008192+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "Fields Assignment", TrackDate = "2024-11-22T09:05:16.7485408+01:00", Workstation = "SPW-MSXIWEBSVB" },
                            new { Value = "Close", TrackDate = "2024-11-22T09:05:16.8028944+01:00", Workstation = "SPW-MSXIWEBSVB" }
                        }
                },
                Status = 0,
                ExecutionDate = "2024-11-22T09:05:16.8650052+01:00",
                ErrorMessage = (object)null
            });


            var responseEntity = new DocumentVerificationResponse
            {
                RequestGuid = requestGuid.ToString(),
                ResponseJson = constantResponseJson
            };


            // Save the request to the database
            await _context.DocumentVerificationResponses.AddAsync(responseEntity);
            await _context.DocumentVerificationRequests.AddAsync(verificationRequest);
            await _context.SaveChangesAsync();

            // Simulate message queuing
            var message = JsonSerializer.Serialize(request);
            Console.WriteLine($"Simulated Queue Message: {message}");

            // Simulate a delay
            await Task.Delay(4000);

            // Return the RequestGuid as part of the response
            return Ok(new { RequestGuid = requestGuid });
        }



        //    [HttpGet("ReadDocumentVerification")]
        //    public IActionResult ReadDocumentVerification(
        //[FromHeader] string sourceSystem,
        //[FromHeader] string channel,
        //[FromHeader(Name = "interactionDate-Time")] string interactionDateTime,
        //[FromHeader] string sessionID,
        //[FromHeader] string messageID,
        //[FromHeader] string userCode,
        //[FromQuery] string requestGuid)
        //    {
        //        if (string.IsNullOrWhiteSpace(requestGuid))
        //            return BadRequest(new { Code = "-1", Message = "Missing requestGuid" });

        //        return Ok(new
        //        {
        //            Batch = new
        //            {
        //                Id = 8765,
        //                Name = "7758334c05f54e598f39f80fc3a8723dc531080867d64f8599131448a5697b02",
        //                CreationDate = "2024-11-22T09:05:13.2311317+01:00",
        //                CloseDate = "2024-11-22T09:05:16.8028944+01:00",
        //                BatchClass = new { Name = "ALLIANZ" },
        //                BatchFields = new[]
        //                {
        //            new { Name = "NAME_IN", Value = "ALESSANDRO", Confidence = 0 },
        //            new { Name = "SURNAME_IN", Value = "GAIA", Confidence = 0 },
        //            new { Name = "CF_IN", Value = "GAILSN70P09E463H", Confidence = 0 },
        //            new { Name = "NAME_OUT", Value = "ALESSANDRO", Confidence = 1 },
        //            new { Name = "SURNAME_OUT", Value = "GAIA", Confidence = 1 },
        //            new { Name = "EXP_DATE_OUT", Value = "2028/11/28", Confidence = 0 }
        //        },
        //                Documents = new[]
        //                {
        //            new
        //            {
        //                Name = "pag1.png",
        //                Pages = new[]
        //                {
        //                    new
        //                    {
        //                        FileName = "000001.png",
        //                        PageTypes = new[] { new { Name = "CIE Fronte", Confidence = 0.95180047 } },
        //                        Sections = (object)null
        //                    }
        //                },
        //                DocumentClass = new { Name = "CIE" },
        //                DocumentFields = Array.Empty<object>(),
        //                Signatures = Array.Empty<object>()
        //            },
        //            new
        //            {
        //                Name = "pag2.png",
        //                Pages = new[]
        //                {
        //                    new
        //                    {
        //                        FileName = "000002.png",
        //                        PageTypes = new[] { new { Name = "CIE Retro", Confidence = 0.9265266 } },
        //                        Sections = (object)null
        //                    }
        //                },
        //                DocumentClass = new { Name = "CIE" },
        //                DocumentFields = Array.Empty<object>(),
        //                Signatures = Array.Empty<object>()
        //            }
        //        },
        //                BatchStates = new[]
        //                {
        //            new { Value = "Start", TrackDate = "2024-11-22T09:05:13.0357384+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "Create", TrackDate = "2024-11-22T09:05:13.2311317+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "OCR", TrackDate = "2024-11-22T09:05:15.6735245+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "Expression Match", TrackDate = "2024-11-22T09:05:16.6689351+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "Classification Page Types", TrackDate = "2024-11-22T09:05:16.7008192+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "Fields Assignment", TrackDate = "2024-11-22T09:05:16.7485408+01:00", Workstation = "SPW-MSXIWEBSVB" },
        //            new { Value = "Close", TrackDate = "2024-11-22T09:05:16.8028944+01:00", Workstation = "SPW-MSXIWEBSVB" }
        //        }
        //            },
        //            Status = 0,
        //            ExecutionDate = "2024-11-22T09:05:16.8650052+01:00",
        //            ErrorMessage = (object)null
        //        });
        //    }


        [HttpPost("MockService")]
        public async Task<IActionResult> InsertDocumentVerification(
        [FromHeader] string requestGuid,
        [FromBody] JsonElement responseBody)
        {
            if (string.IsNullOrWhiteSpace(requestGuid))
            {
                return BadRequest(new { Code = "-1", Message = "Missing requestGuid" });
            }

            var responseJson = responseBody.GetRawText();

            if (string.IsNullOrWhiteSpace(responseJson))
            {
                return BadRequest(new { Code = "-1", Message = "Missing or empty responseJson" });
            }

            var existing = await _context.DocumentVerificationResponses.FindAsync(requestGuid);
            if (existing != null)
            {
                existing.ResponseJson = responseJson;
                _context.DocumentVerificationResponses.Update(existing);
                await _context.SaveChangesAsync();

                return Ok(new { Code = "1", Message = "ResponseJson updated successfully", RequestGuid = requestGuid });
            }

            var entity = new DocumentVerificationResponse
            {
                RequestGuid = requestGuid,
                ResponseJson = responseJson
            };

            _context.DocumentVerificationResponses.Add(entity);
            await _context.SaveChangesAsync();

            return Ok(new { Code = "0", Message = "Processed successfully", RequestGuid = requestGuid });
        }




        [HttpGet("ReadDocumentVerification")]
        public async Task<IActionResult> ReadDocumentVerification(
        [FromHeader] string sourceSystem,
        [FromHeader] string channel,
        [FromHeader(Name = "interactionDate-Time")] string interactionDateTime,
        [FromHeader] string sessionID,
        [FromHeader] string messageID,
        [FromHeader] string userCode,
        [FromQuery] string requestGuid)  
        {
            if (string.IsNullOrWhiteSpace(requestGuid))
                return BadRequest(new { Code = "-1", Message = "Missing requestGuid" });

            var responseRecord = await _context.DocumentVerificationResponses
                .FindAsync(requestGuid);  

            if (responseRecord == null)
                return NotFound(new { Code = "-2", Message = "No response found for given requestGuid" });
            
            // Simulate a delay
            await Task.Delay(4000);

            return Content(responseRecord.ResponseJson, "application/json");
        }

    }
}