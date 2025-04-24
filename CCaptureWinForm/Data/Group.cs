using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CCaptureWinForm.Data;

public partial class Group
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(50)]
    public string GroupName { get; set; } = null!;

    public bool IsSubmitted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [InverseProperty("Group")]
    public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
}
