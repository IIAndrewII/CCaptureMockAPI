using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
        //private readonly IConnection _connection;
        //private readonly IModel _channel;
        //private const string QueueName = "CCaptureQueue";

        //public DocumentController()
        //{
        //    var factory = new ConnectionFactory { HostName = "localhost" }; // Update as needed
        //    _connection = factory.CreateConnection();
        //    _channel = _connection.CreateModel();
        //    _channel.QueueDeclare(queue: QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
        //}

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

            // Simulating message queuing
            var message = JsonSerializer.Serialize(request);
            Console.WriteLine($"Simulated Queue Message: {message}");


            return Ok(new { RequestGuid = Guid.NewGuid().ToString() });
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