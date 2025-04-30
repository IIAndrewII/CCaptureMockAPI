using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Data;

public partial class BatchClass
{
    public int BatchClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();
}
