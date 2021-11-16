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
    public class StaffController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public StaffController(myDBContext _db)
        {
            db = _db;
        }
        */
        // GET: api/Staff
        [HttpGet]
        public ActionResult<StaffTable> Get()
        {
           var myStaff =  db.StaffTables.Include(s=>s.RoleStaffs);
            return Ok(myStaff);
        }

        // GET: api/Staff/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<StaffTable> Get(string id)
        {
            var myStaff = db.StaffTables.Include(s=>s.RoleStaffs).FirstOrDefault(s=>s.StaffId == id);

            return Ok(myStaff);
        }

        // POST: api/Staff
        [HttpPost]
        public ActionResult<StaffTable> Post([FromBody] StaffTable addedStaff)
        {
            db.StaffTables.Add(addedStaff);
            db.SaveChanges();
            return StatusCode(201);

        }

        // PUT: api/Staff/5
        [HttpPut("{id}")]
        public ActionResult<StaffTable> Put(string id, [FromBody] StaffTable staff)
        {
            var FoundStaff = db.StaffTables.FirstOrDefault(q => q.StaffId == id);

            FoundStaff.FullName = staff.FullName;
            FoundStaff.NationalIdno = staff.NationalIdno;
            FoundStaff.Photo = staff.Photo;

            db.SaveChanges();
            return StatusCode(202);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<StaffTable> Delete(string id)
        {
            var myStaff = db.StaffTables.FirstOrDefault(s => s.StaffId == id);
            db.StaffTables.Remove(myStaff);
            db.SaveChanges();
            return Ok("Staff Successfully Deleted!!");

        }
        
    }
}
