using Konecta.Tools.CCaptureClient.Core.DbEntities;
using Konecta.Tools.CCaptureClient.Presentation.ViewModels;

namespace Konecta.Tools.CCaptureClient.Core.Interfaces
{
    public interface IDatabaseService
    {
        Task<int> SaveGroupAsync(string groupName, bool isSubmitted);
        Task<int> SaveSubmissionAsync(int groupId, string batchClassName, string sourceSystem, string channel, string sessionId, string messageId, string userCode, string interactionDateTime, string requestGuid, string authToken);
        Task SaveDocumentAsync(int submissionId, string filePath, string pageType, string fileName);
        Task SaveFieldAsync(int submissionId, string fieldName, string fieldValue, string fieldType);
        Task<SubmissionDetailsViewModel> GetSubmissionDetailsAsync(string requestGuid);
        Task<int> SaveVerificationResponseAsync(VerificationResponse verificationResponse);
        Task<bool> UpdateCheckedGuidAsync(string requestGuid);
        Task<List<string>> GetUncheckedRequestGuidsAsync();
        Task<List<VerificationResponse>> GetAllVerificationResponses();
        Task<List<VerificationResponseViewModel>> GetFilteredVerificationResponses(
            DateTime? startDate = null,
            DateTime? endDate = null,
            int? status = null,
            string? sourceSystem = null,
            string? channel = null);
    }
}
