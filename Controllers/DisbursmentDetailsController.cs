using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.Models;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisbursmentDetailsController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

        //public DisbursmentDetailsController(myDBContext _db)
        //{
          //  db = _db;
        //}

        // GET: api/DisbursmentDetails
        [HttpGet]
        public ActionResult<DisbursmentDetailsTable> Get()
        {
            return Ok(db.DisbursmentDetailsTables);
        }

        // GET: api/DisbursmentDetails/5
        [HttpGet("{id}", Name = "GetDisbursmentDetails")]
        public ActionResult<DisbursmentDetailsTable> Get(int id)
        {
            return Ok(db.DisbursmentDetailsTables.FirstOrDefault(a => a.DisbursmentId == id));
        }

        // POST: api/DisbursmentDetails
        [HttpPost]
        public ActionResult<DisbursmentDetailsTable> Post([FromBody] DisbursmentDetailsTable disbursmentDetails)
        {
            db.DisbursmentDetailsTables.Add(disbursmentDetails);
            db.SaveChanges();
            return Accepted();

        }

        // PUT: api/DisbursmentDetails/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<DisbursmentDetailsTable> Delete(int id)
        {
            var mydis = db.DisbursmentDetailsTables.FirstOrDefault(a => a.DisbursmentId == id);
            db.DisbursmentDetailsTables.Remove(mydis);
            db.SaveChanges();
            return Accepted();
            
        }
        
    }
}
