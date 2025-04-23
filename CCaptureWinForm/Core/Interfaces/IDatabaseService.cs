namespace CCaptureWinForm.Core.Interfaces
{
    public interface IDatabaseService
    {
        Task<List<string>> GetBatchClassNamesAsync();
        Task<List<string>> GetFieldNamesAsync(string batchClassName);
        Task<List<string>> GetPageTypesAsync(string batchClassName);
    }
}
