using System;
using System.Collections.Generic;

namespace CCaptureMockAPI.Models;

public partial class DocumentVerificationRequest
{
    public int Id { get; set; }

    public Guid RequestGuid { get; set; }

    public string BatchClassName { get; set; } = null!;

    public string? Fields { get; set; }

    public string? Documents { get; set; }

    public string? FilePath { get; set; }

    public DateTime CreatedAt { get; set; }
}
