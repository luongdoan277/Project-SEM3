using HomePage.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Services
{
    public class UploadService
    {
        public void UploadImage(IFormFile file)
        {
            var stream = file.OpenReadStream();
            var name = Path.GetFileName(file.FileName);
        }
    }
}
