using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Models;

public partial class VerificationResponse
{
    public int VerificationResponseId { get; set; }

    public int? BatchId { get; set; }

    public int Status { get; set; }

    public DateTime ExecutionDate { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual Batch? Batch { get; set; }
}
