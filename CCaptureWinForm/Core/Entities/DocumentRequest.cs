using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCaptureWinForm.Core.Entities
{
    public class DocumentRequest
    {
        public string BatchClassName { get; set; }
        public Dictionary<string, string> Fields { get; set; } = new();
        public List<Document> Documents { get; set; } = new();
        public string SourceSystem { get; set; }
        public string Channel { get; set; }
        public string InteractionDateTime { get; set; }
        public string SessionID { get; set; }
        public string MessageID { get; set; }
        public string UserCode { get; set; }
    }
}
