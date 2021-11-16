using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Data;
//using SomaSuiteBackEnd.Models;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

       // public HealthController(myDBContext _db)
       // {
         //   db = _db;
       // }

        // GET: api/Health
        [HttpGet]
        public ActionResult<HealthTable> Get()
        {
            return Ok(db.HealthTables);
        }

        // GET: api/Health/5
        [HttpGet("{id}", Name = "GetHealth")]
        public ActionResult<HealthTable> Get(int id)
        {
            return Ok(db.HealthTables.FirstOrDefault(h => h.HealthId == id));
        }

        // POST: api/Health
        [HttpPost]
        public ActionResult<HealthTable> Post([FromBody] HealthTable health)
        {
            db.HealthTables.Add(health);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Health/5
        [HttpPut("{id}")]
        public ActionResult<HealthTable> Put(int id, [FromBody] HealthTable health)
        {
            var foundHealth = db.HealthTables.FirstOrDefault(h => h.HealthId == id);
            foundHealth.BloodGroup = health.BloodGroup;
            foundHealth.Allergies = health.Allergies;
            foundHealth.Disabilities = health.Disabilities;
            foundHealth.LongTermConditions = health.LongTermConditions;

            db.SaveChanges();
            return Accepted();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<HealthTable> Delete(int id)
        {
            var foundHealth = db.HealthTables.FirstOrDefault(h => h.HealthId == id);
            db.HealthTables.Remove(foundHealth);
            db.SaveChanges();
            return Accepted();
        }
    }
}
