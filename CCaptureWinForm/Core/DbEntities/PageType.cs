using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Core.DbEntities;

public partial class PageType
{
    public int PageTypeId { get; set; }

    public int PageId { get; set; }

    public string Name { get; set; } = null!;

    public double Confidence { get; set; }

    public virtual Page Page { get; set; } = null!;
}
