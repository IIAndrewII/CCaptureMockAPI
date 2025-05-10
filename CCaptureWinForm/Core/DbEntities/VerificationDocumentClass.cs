using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Core.DbEntities;

public partial class VerificationDocumentClass
{
    public int DocumentClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<VerificationDocument> VerificationDocuments { get; set; } = new List<VerificationDocument>();
}
