using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Data;
//using SomaSuiteBackEnd.Models;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiansController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

       // public GuardiansController(myDBContext _db)
       // {
         //   db = _db;
       // }

        // GET: api/Guardians
        [HttpGet]
        public ActionResult<GuardiansTable> Get()
        {
            return Ok(db.GuardiansTables.Include(g=>g.GuardiansPupils));
        }

        // GET: api/Guardians/5
        [HttpGet("{id}", Name = "GetGuardian")]
        public ActionResult<GuardiansTable> Get(string id)
        {
            return Ok(db.GuardiansTables.Include(g => g.GuardiansPupils).FirstOrDefault(g => g.NationalId == id));
        }

        // POST: api/Guardians
        [HttpPost]
        public ActionResult<GuardiansTable> Post([FromBody] GuardiansTable Guardian)
        {
            db.GuardiansTables.Add(Guardian);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Guardians/5
        [HttpPut("{id}")]
        public ActionResult<GuardiansTable> Put(string id, [FromBody] GuardiansTable Guardian)
        {
            var foundGuardian = db.GuardiansTables.FirstOrDefault(g => g.NationalId == id);
            foundGuardian.ParentName = Guardian.ParentName;
            foundGuardian.PhoneNumber = Guardian.PhoneNumber;
            foundGuardian.Dob = Guardian.Dob;
            db.SaveChanges();
            return Accepted();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<GuardiansTable> Delete(string id)
        {
            var foundGuardian = db.GuardiansTables.FirstOrDefault(g => g.NationalId == id);
            db.GuardiansTables.Remove(foundGuardian);
            db.SaveChanges();
            return Accepted();
        }
    }
}
