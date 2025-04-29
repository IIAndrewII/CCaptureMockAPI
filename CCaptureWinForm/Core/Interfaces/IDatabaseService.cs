using CCaptureWinForm.Presentation.ViewModels;

namespace CCaptureWinForm.Core.Interfaces
{
    public interface IDatabaseService
    {
        Task<int> SaveGroupAsync(string groupName, bool isSubmitted);
        Task<int> SaveSubmissionAsync(int groupId, string batchClassName, string sourceSystem, string channel, string sessionId, string messageId, string userCode, string interactionDateTime, string requestGuid, string authToken);
        Task SaveDocumentAsync(int submissionId, string filePath, string pageType, string fileName);
        Task SaveFieldAsync(int submissionId, string fieldName, string fieldValue, string fieldType);
        Task<SubmissionDetails> GetSubmissionDetailsAsync(string requestGuid);
    }
}
