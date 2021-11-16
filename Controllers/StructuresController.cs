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
    public class StructuresController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public StructuresController(myDBContext _db)
        {
            db = _db;
        }
        */

        // GET: api/Structures
        [HttpGet]
        public ActionResult<StructuresTable> Get()
        {
            return Ok(db.StructuresTables.Include(s=>s.StructureDetailsTables).Include(s=>s.PupilsStructures));
        }

        // GET: api/Structures/5
        [HttpGet("{id}", Name = "GetTruct")]
        public ActionResult<StructuresTable> Get(int id)
        {
            return Ok(db.StructuresTables.Include(s => s.StructureDetailsTables).Include(s => s.PupilsStructures).FirstOrDefault(s => s.StructureId == id));
        }

        // POST: api/Structures
        [HttpPost]
        public ActionResult<StructuresTable> Post([FromBody] StructuresTable S)
        {
            db.StructuresTables.Add(S);
            db.SaveChanges();
            return Accepted();

        }

        // PUT: api/Structures/5
        [HttpPut("{id}")]
        public ActionResult<StructuresTable> Put(int id, [FromBody] StructuresTable S)
        {
            var FS = db.StructuresTables.FirstOrDefault(s => s.StructureId == id);
            FS.StructureName = S.StructureName;
            db.SaveChanges();
            return Accepted();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<StructuresTable> Delete(int id)
        {
            var FS = db.StructuresTables.FirstOrDefault(s => s.StructureId == id);
            db.StructuresTables.Remove(FS);
            db.SaveChanges();
            return Accepted();

        }
    }
}
