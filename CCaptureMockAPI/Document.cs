using System;
using System.Collections.Generic;

namespace CCaptureMockAPI;

public partial class Document
{
    public int DocumentId { get; set; }

    public int SubmissionId { get; set; }

    public string FilePath { get; set; } = null!;

    public string? PageType { get; set; }

    public string FileName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Submission Submission { get; set; } = null!;
}
