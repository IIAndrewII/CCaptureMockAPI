using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Data;

public partial class BatchField
{
    public int BatchFieldId { get; set; }

    public int BatchId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public double Confidence { get; set; }

    public virtual Batch Batch { get; set; } = null!;
}
