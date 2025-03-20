using System.Collections.Generic;

namespace CCaptureMockAPI.Models
{
    public class DocumentRequest
    {
        public string BatchClassName { get; set; }
        public List<Field> Fields { get; set; }
        public List<Document> Documents { get; set; }
    }

    public class Field
    {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
    }

    public class Document
    {
        public string PageType { get; set; }
        public string FileName { get; set; }
        public string Buffer { get; set; }
    }
}
