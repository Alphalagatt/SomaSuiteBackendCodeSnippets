using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.Models;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalancesController : ControllerBase
    {
        /*
        myDBContext db = new myDBContext();
        // GET: api/Balances
        [HttpGet]
        public ActionResult<Balances> Get()
        {
            return Ok(db.BalancesTable);
        }

        // GET: api/Balances/5
        [HttpGet("{id}", Name = "GetBalance")]
        public ActionResult<Balances> Get(string id)
        {
            return Ok(db.BalancesTable.FirstOrDefault(a=>a.StudentID==id));
        }

        // POST: api/Balances
        [HttpPost]
        public ActionResult<Balances> Post([FromBody] Balances myBalance)
        {
            db.BalancesTable.Add(myBalance);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Balances/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Balances> Delete(string id)
        {
            var foundBalance = db.BalancesTable.FirstOrDefault(a => a.StudentID == id);
            db.BalancesTable.Remove(foundBalance);
            db.SaveChanges();
            return Accepted();
        }
        */
    }
}
