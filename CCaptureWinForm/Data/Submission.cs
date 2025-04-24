using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CCaptureWinForm.Data;

[Index("RequestGuid", Name = "UQ__Submissi__27CC2CAAE43016F1", IsUnique = true)]
public partial class Submission
{
    [Key]
    public int SubmissionId { get; set; }

    public int GroupId { get; set; }

    [StringLength(100)]
    public string BatchClassName { get; set; } = null!;

    [StringLength(50)]
    public string SourceSystem { get; set; } = null!;

    [StringLength(50)]
    public string Channel { get; set; } = null!;

    [StringLength(50)]
    public string SessionId { get; set; } = null!;

    [StringLength(50)]
    public string MessageId { get; set; } = null!;

    [StringLength(50)]
    public string UserCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InteractionDateTime { get; set; }

    [StringLength(36)]
    public string RequestGuid { get; set; } = null!;

    [StringLength(500)]
    public string? AuthToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmittedAt { get; set; }

    [InverseProperty("Submission")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("Submission")]
    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();

    [ForeignKey("GroupId")]
    [InverseProperty("Submissions")]
    public virtual Group Group { get; set; } = null!;
}
