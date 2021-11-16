using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

        //public GradeController(myDBContext _db)
        //{
          //  db = _db;
        //}
        // GET: api/Grade
        [HttpGet]
        public ActionResult<GradeTable> Get()
        {
            return Ok(db.GradeTables.Include("GradeStreams").Include("PupilsTables")); 
        }

        // GET: api/Grade/5
        [HttpGet("{id}", Name = "GetGrade")]
        public ActionResult<GradeTable> Get(int id)
        {
            return Ok(db.GradeTables.Include(s=>s.GradeStreams).Include("PupilsTables").FirstOrDefault(g => g.GradeId == id));
        }

        // POST: api/Grade
        [HttpPost]
        public ActionResult<GradeTable> Post([FromBody] GradeTable grade)
        {
            db.GradeTables.Add(grade);
            db.SaveChanges();
            return Accepted("Grade Successfully Added!!");

        }

        // PUT: api/Grade/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GradeTable grade)
        {
            var foundGrade = db.GradeTables.FirstOrDefault(g => g.GradeId == id);
            foundGrade.GradeName = grade.GradeName;
            foundGrade.Pos = grade.Pos;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<GradeTable> Delete(int id)
        {
            var grade = db.GradeTables.FirstOrDefault(g => g.GradeId == id);
            db.GradeTables.Remove(grade);
            db.SaveChanges();
            return Accepted("Grade successfully Deleted!!");

        }
    }
}
