using System;
using System.Collections.Generic;

namespace CCaptureMockAPI;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public bool IsSubmitted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
}
