using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CCaptureWinForm.Data;

public partial class Document
{
    [Key]
    public int DocumentId { get; set; }

    public int SubmissionId { get; set; }

    [StringLength(500)]
    public string FilePath { get; set; } = null!;

    [StringLength(50)]
    public string? PageType { get; set; }

    [StringLength(100)]
    public string FileName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("SubmissionId")]
    [InverseProperty("Documents")]
    public virtual Submission Submission { get; set; } = null!;
}
