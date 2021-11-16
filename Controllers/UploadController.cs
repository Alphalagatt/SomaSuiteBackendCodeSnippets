using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Models;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        public static IWebHostEnvironment _hostEnv;

        public UploadController(IWebHostEnvironment HostEnv)
        {
            _hostEnv = HostEnv;
        }

        [HttpPost]
        public ActionResult<PhotoUpload> Post([FromForm] PhotoUpload uploadedPhoto)
        {
            try
            {
                if (uploadedPhoto.myProfilePics.Length > 0)
                {
                    string Path = _hostEnv.WebRootPath + "\\uploads\\";

                    using (FileStream fileStream = System.IO.File.Create(Path + uploadedPhoto.myProfilePics.FileName))
                    {
                        uploadedPhoto.myProfilePics.CopyTo(fileStream);
                        fileStream.Flush();
                        return Accepted(Path);
                    }
                }
                else
                {
                    return StatusCode(404, "Unable to Upload Photo!");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(404, "Unable to Upload Photo. " + ex.Message);
            }



        }

        [HttpDelete("{ImageUrl}")]
        public ActionResult<PhotoUpload> Delete(string ImageUrl)
        {

            string Path = _hostEnv.WebRootPath + "\\uploads\\" + ImageUrl;
            FileInfo fi = new FileInfo(ImageUrl);

            if (fi != null)
            {
                System.IO.File.Delete(Path);
                return Accepted();
            }
            else
            {
                return StatusCode(404);
            }
        }
        
    }
}