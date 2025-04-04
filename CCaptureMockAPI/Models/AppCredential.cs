using System;
using System.Collections.Generic;

namespace CCaptureMockAPI.Models;

public partial class AppCredential
{
    public int Id { get; set; }

    public string ApplicationName { get; set; } = null!;

    public string AppLogin { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;
}
