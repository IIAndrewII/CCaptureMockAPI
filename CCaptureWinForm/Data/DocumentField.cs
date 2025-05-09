﻿using System;
using System.Collections.Generic;

namespace CCaptureWinForm.Data;

public partial class DocumentField
{
    public int DocumentFieldId { get; set; }

    public int VerificationDocumentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public double? Confidence { get; set; }

    public virtual VerificationDocument VerificationDocument { get; set; } = null!;
}
