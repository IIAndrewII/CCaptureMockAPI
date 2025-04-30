using System;
using System.Collections.Generic;

namespace CCaptureWinForm;

public partial class Signature
{
    public int SignatureId { get; set; }

    public int VerificationDocumentId { get; set; }

    public string? SignatureData { get; set; }

    public virtual VerificationDocument VerificationDocument { get; set; } = null!;
}
