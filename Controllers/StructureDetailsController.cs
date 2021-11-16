using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.TestModels;
//using SomaSuiteBackEnd.Models;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StructureDetailsController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public StructureDetailsController(myDBContext _db)
        {
            db = _db;
        }
        */

        // GET: api/StructureDetails
        [HttpGet]
        public ActionResult<StructureDetailsTable> Get()
        {
            return Ok(db.StructureDetailsTables);
        }

        // GET: api/StructureDetails/5
        [HttpGet("{id}", Name = "GetStructureDetails")]
        public ActionResult<StructureDetailsTable> Get(int id)
        {
            return Ok(db.StructureDetailsTables.FirstOrDefault(sd => sd.StructureDetailsId == id));
        }

        // POST: api/StructureDetails
        [HttpPost]
        public ActionResult<StructureDetailsTable> Post([FromBody] StructureDetailsTable SD)
        {
            db.StructureDetailsTables.Add(SD);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/StructureDetails/5
        [HttpPut("{id}")]
        public ActionResult<StructureDetailsTable> Put(int id, [FromBody] StructureDetailsTable SD)
        {
            var FoundStructure = db.StructureDetailsTables.FirstOrDefault(sd => sd.StructureDetailsId == id);
            FoundStructure.DetailName = SD.DetailName;
            FoundStructure.Amount = SD.Amount;
            db.SaveChanges();
            return Accepted();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<StructureDetailsTable> Delete(int id)
        {
            var FoundStructure = db.StructureDetailsTables.FirstOrDefault(sd => sd.StructureDetailsId == id);
            db.StructureDetailsTables.Remove(FoundStructure);
            db.SaveChanges();
            return Accepted();
        }
    }
}
