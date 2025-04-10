using CCaptureWinForm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCaptureWinForm.Infrastructure.Services
{
    public class FileService : IFileService
    {
        public string ReadFileAsBase64(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(fileBytes);
        }

        public string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }
    }
}
