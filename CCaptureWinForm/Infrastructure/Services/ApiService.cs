// CCaptureMockApiClient.Infrastructure/Services/ApiService.cs
using CCaptureWinForm.Core.Entities;
using CCaptureWinForm.Core.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CCaptureWinForm.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiService(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<string> GetAuthTokenAsync(AuthCredentials credentials)
        {
            var content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_baseUrl}/ProcessDocument/GetToken", content);

            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(responseContent);
            return result.result;
        }

        public async Task<string> SubmitDocumentAsync(DocumentRequest request, string authToken)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new
            {
                request.BatchClassName,
                request.Fields,
                request.Documents
            }), Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            _httpClient.DefaultRequestHeaders.Add("sourceSystem", request.SourceSystem);
            _httpClient.DefaultRequestHeaders.Add("channel", request.Channel);
            _httpClient.DefaultRequestHeaders.Add("interactionDate-Time", request.InteractionDateTime);
            _httpClient.DefaultRequestHeaders.Add("sessionID", request.SessionID);
            _httpClient.DefaultRequestHeaders.Add("messageID", request.MessageID);
            _httpClient.DefaultRequestHeaders.Add("userCode", request.UserCode);

            var response = await _httpClient.PostAsync($"{_baseUrl}/ProcessDocument/StartDocumentVerification", content);

            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(responseContent);
            return result.RequestGuid;
        }

        public async Task<string> CheckVerificationStatusAsync(VerificationStatusRequest request, string authToken)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            _httpClient.DefaultRequestHeaders.Add("sourceSystem", request.SourceSystem);
            _httpClient.DefaultRequestHeaders.Add("channel", request.Channel);
            _httpClient.DefaultRequestHeaders.Add("interactionDate-Time", request.InteractionDateTime);
            _httpClient.DefaultRequestHeaders.Add("sessionID", request.SessionID);
            _httpClient.DefaultRequestHeaders.Add("messageID", request.MessageID);
            _httpClient.DefaultRequestHeaders.Add("userCode", request.UserCode);

            var response = await _httpClient.GetAsync($"{_baseUrl}/ProcessDocument/ReadDocumentVerification?requestGuid={request.RequestGuid}");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}