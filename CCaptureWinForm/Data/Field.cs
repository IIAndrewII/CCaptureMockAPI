using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CCaptureWinForm.Data;

public partial class Field
{
    [Key]
    public int FieldId { get; set; }

    public int SubmissionId { get; set; }

    [StringLength(100)]
    public string FieldName { get; set; } = null!;

    [StringLength(500)]
    public string FieldValue { get; set; } = null!;

    [StringLength(50)]
    public string? FieldType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("SubmissionId")]
    [InverseProperty("Fields")]
    public virtual Submission Submission { get; set; } = null!;
}
