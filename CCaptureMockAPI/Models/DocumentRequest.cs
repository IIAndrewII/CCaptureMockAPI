using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CCaptureMockAPI.Models
{
    public class DocumentRequest
    {
        public string BatchClassName { get; set; }
        public List<Field> Fields { get; set; }
        [Required]
        public List<Document> Documents { get; set; }
    }

    public class Field
    {
        [Required]
        public string FieldName { get; set; }
        [Required]
        public string FieldValue { get; set; }
    }

    public class Document
    {
        public string? PageType { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string Buffer { get; set; } // Base64 string
    }
}
