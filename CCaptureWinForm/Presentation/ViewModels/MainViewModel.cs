using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCaptureWinForm.Presentation.ViewModels
{
    public class MainViewModel
    {
        private readonly IApiService _apiService;
        private readonly IFileService _fileService;
        private string _authToken;
        private string _lastRequestGuid;

        public MainViewModel(IApiService apiService, IFileService fileService)
        {
            _apiService = apiService;
            _fileService = fileService;
        }

        public async Task<string> GetAuthTokenAsync(string appName, string appLogin, string appPassword)
        {
            var credentials = new AuthCredentials
            {
                ApplicationName = appName,
                AppLogin = appLogin,
                AppPassword = appPassword
            };

            _authToken = await _apiService.GetAuthTokenAsync(credentials);
            return _authToken;
        }

        public async Task<string> SubmitDocumentAsync(
            string filePath,
            string batchClassName,
            string pageType,
            string sourceSystem,
            string channel,
            string sessionId,
            string messageId,
            string userCode,
            List<Field> fields)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    throw new ArgumentException("Please select a file first");
                }

                var base64Content = _fileService.ReadFileAsBase64(filePath);
                var fileName = _fileService.GetFileName(filePath);

                var request = new DocumentRequest
                {
                    BatchClassName = batchClassName,
                    Documents = new List<Document>
                    {
                        new Document
                        {
                            FileName = fileName,
                            Buffer = base64Content,
                            PageType = pageType
                        }
                    },
                    SourceSystem = sourceSystem,
                    Channel = channel,
                    InteractionDateTime = DateTime.Now.ToString("o"),
                    SessionID = sessionId,
                    MessageID = messageId,
                    UserCode = userCode,
                    Fields = fields
                };
                _lastRequestGuid = await _apiService.SubmitDocumentAsync(request, _authToken);
                return _lastRequestGuid;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to submit document: {ex.Message}", ex);
            }
        }

        public async Task<string> CheckVerificationStatusAsync(
            string requestGuid,
            string sourceSystem,
            string channel,
            string sessionId,
            string messageId,
            string userCode)
        {
            var request = new VerificationStatusRequest
            {
                RequestGuid = string.IsNullOrEmpty(requestGuid) ? _lastRequestGuid : requestGuid,
                SourceSystem = sourceSystem,
                Channel = channel,
                InteractionDateTime = DateTime.Now.ToString("o"),
                SessionID = sessionId,
                MessageID = messageId,
                UserCode = userCode
            };

            return await _apiService.CheckVerificationStatusAsync(request, _authToken);
        }
    }
}