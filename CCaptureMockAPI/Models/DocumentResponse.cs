using System.ComponentModel.DataAnnotations;

namespace CCaptureMockAPI.Models
{
    public class DocumentResponse
    {
        public Batch Batch { get; set; }
        public int Status { get; set; }
        public string ExecutionDate { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Batch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string CloseDate { get; set; }
        public BatchClass BatchClass { get; set; }
        public List<BatchField> BatchFields { get; set; }
        public List<Document> Documents { get; set; }
        public List<BatchState> BatchStates { get; set; }
    }

    public class BatchClass { public string Name { get; set; } }

    public class BatchField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public double Confidence { get; set; }
    }

    public class BatchState
    {
        public string Value { get; set; }
        public string TrackDate { get; set; }
        public string Workstation { get; set; }
    }

    public class DocumentVerificationResponse
    {
        [Key]
        public string RequestGuid { get; set; }

        [Required]
        public string ResponseJson { get; set; }
    }

}
