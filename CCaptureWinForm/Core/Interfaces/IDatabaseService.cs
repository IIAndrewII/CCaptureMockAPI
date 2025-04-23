namespace CCaptureWinForm.Core.Interfaces
{
    public interface IDatabaseService
    {
        Task<List<string>> GetBatchClassNamesAsync();
        Task<List<string>> GetFieldNamesAsync(string batchClassName);
        Task<string> GetFieldTypeAsync(string fieldName);
        Task<List<string>> GetPageTypesAsync(string batchClassName);
    }
}
