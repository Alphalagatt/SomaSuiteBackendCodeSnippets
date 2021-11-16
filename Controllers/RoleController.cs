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
    public class RoleController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

       // public RoleController(myDBContext _db)
       // {
         //   db = _db;
       // }

        // GET: api/Role
        [HttpGet]
        public ActionResult<RolesTable> Get()
        {
            return Ok(db.RolesTables.Include(r=>r.RoleStaffs));
        }

        // GET: api/Role/5
        [HttpGet("{id}", Name = "GetRole")]
        public ActionResult<RolesTable> Get(int id)
        {
            return Ok(db.RolesTables.Include(r => r.RoleStaffs).FirstOrDefault(r => r.RoleId == id));
        }

        // POST: api/Role
        [HttpPost]
        public ActionResult<RolesTable> Post([FromBody] RolesTable role)
        {
            db.RolesTables.Add(role);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Role/5
        [HttpPut("{id}")]
        public ActionResult<RolesTable> Put(int id, [FromBody] RolesTable role)
        {
            var foundRole = db.RolesTables.FirstOrDefault(r => r.RoleId == id);
            foundRole.RoleName = role.RoleName;
            foundRole.Description = role.Description;
            db.SaveChanges();
            return Accepted();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<RolesTable> Delete(int id)
        {
            var foundRole = db.RolesTables.FirstOrDefault(r => r.RoleId == id);
            db.RolesTables.Remove(foundRole);
            db.SaveChanges();

            return Accepted();
        }
    }
}
