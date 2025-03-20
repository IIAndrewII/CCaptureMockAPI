using System;
using CCaptureMockAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CCaptureMockApi.Controllers
{
    [ApiController]
    [Route("ProcessDocument")]
    [Authorize]
    public class DocumentController : ControllerBase
    {
        [HttpPost("StartDocumentVerification")]
        public IActionResult StartDocumentVerification(
            [FromHeader] string sourceSystem,
            [FromHeader] string channel,
            [FromHeader(Name = "interactionDate-Time")] string interactionDateTime,
            [FromHeader] string sessionID,
            [FromHeader] string messageID,
            [FromHeader] string userCode,
            [FromBody] DocumentRequest request)
        {
            if (request == null)
                return BadRequest(new ErrorResponse { Code = "-1", Message = "Invalid input" });

            // Simulate file processing and return a response
            var response = new
            {
                BatchClassName = "Allianz Modules",
                Documents = new List<object>
                {
                    new { FileName = "File1.ext", Buffer = "/9j/4AAQSkZJRgABAQEAeAB4AAD/4RD6RXhpZgAATU0AKgAAAA[...]" },
                    new { FileName = "File2.ext", Buffer = "/9j/4AAQSkZJRgABAQEAeAB4AAD/4RD6RXhpZgAATU0AKgAAAA[...]" }
                }
            };

            return Ok(response);
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

            return Ok(new DocumentResponse
            {
                Status = 200,
                ExecutionDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"),
                Batch = new Batch
                {
                    Id = 1,
                    Name = requestGuid,
                    CreationDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"),
                    CloseDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"),
                    BatchClass = new BatchClass { Name = "BATCH_CLASS" },
                    BatchFields = new System.Collections.Generic.List<BatchField>
                    {
                        new BatchField { Name = "Field1", Value = "Value1", Confidence = 0.99 }
                    },
                    BatchStates = new System.Collections.Generic.List<BatchState>
                    {
                        new BatchState { Value = "OCR", TrackDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss"), Workstation = "WEB_SERVER" }
                    }
                }
            });
        }
    }
}