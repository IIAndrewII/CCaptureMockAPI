using System;
using System.Collections.Generic;

namespace CCaptureMockAPI.Models;

public partial class DocumentVerificationResponse
{
    public string RequestGuid { get; set; } = null!;

    public string ResponseJson { get; set; } = null!;
}
