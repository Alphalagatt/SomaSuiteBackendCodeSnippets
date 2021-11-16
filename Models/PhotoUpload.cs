using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomaSuiteBackEnd.Models
{
    public class PhotoUpload
    {
        public IFormFile myProfilePics { get; set; }
    }
}
