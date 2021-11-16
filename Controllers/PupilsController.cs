using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.TestModels;
//using SomaSuiteBackEnd.Models;


namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilsController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db; 

       // public PupilsController(myDBContext _db)
       // {
        //    db = _db;
       // }


        // GET: api/Pupils
        [HttpGet]
        public ActionResult<PupilsTable> Get()
        {
            return  Ok(db.PupilsTables.Include(p=>p.Grade).Include(p=>p.Stream).Include(p=>p.Health));
        }

        // GET: api/Pupils/5
        [HttpGet("{id}", Name = "GetPupil")]
        public ActionResult<PupilsTable> Get(string id)
        {
            return Ok(db.PupilsTables.Include("Grade").Include("Stream").Include("Health").FirstOrDefault(p => p.PupilRegNo == id));
        }

        // POST: api/Pupils
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Pupils/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
