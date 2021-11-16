using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.Models;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisbursmentsController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

        //private readonly myDBContext db;

        //public DisbursmentsController(myDBContext _db)
        //{
          //  db = _db;
        //}

        // GET: api/Disbursments
        [HttpGet]
        public ActionResult<DisbursmentsTable> Get()
        {
            return Ok(db.DisbursmentsTables.Include(d=>d.DisbursmentDetailsTables));
        }

        // GET: api/Disbursments/5
        [HttpGet("{id}", Name = "GetDisburments")]
        public ActionResult<DisbursmentsTable> Get(int id)
        {
            return Ok(db.DisbursmentsTables.Include(d=>d.DisbursmentDetailsTables).FirstOrDefault(a => a.DisbursmentRecordId == id));

        }

        // POST: api/Disbursments
        [HttpPost]
        public ActionResult<DisbursmentsTable> Post([FromBody] DisbursmentsTable disbursments)
        {
            db.DisbursmentsTables.Add(disbursments);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Disbursments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<DisbursmentsTable> Delete(int id)
        {
            var mydisb = db.DisbursmentsTables.FirstOrDefault(a => a.DisbursmentRecordId == id);
            db.DisbursmentsTables.Remove(mydisb);
            db.SaveChanges();
            return Accepted();
        }
        
    }
}
