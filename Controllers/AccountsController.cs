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
    [Route("api/Accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

        //private readonly SomaSuiteDbContext db;

        //public AccountsController(SomaSuiteDbContext _db)
        //{
          //  db = _db;
        //}

        // GET: api/Accounts
        [HttpGet]
        public ActionResult<AccountsTable> Get()
        {
            return Ok(db.AccountsTables.Include("Account").Include("DisbursmentDetailsTables").Include("PaymentRecordsTables"));
        }

        // GET: api/Accounts/5
        [HttpGet("{id}", Name = "GetAccount")]
        public ActionResult<AccountsTable> Get(string id)
        {
            var myAccount = db.AccountsTables.FirstOrDefault(a => a.AccountId == id);
            return Ok(myAccount);
        }

        // POST: api/Accounts
        [HttpPost]
        public ActionResult<AccountsTable> Post([FromBody] AccountsTable myAccount)
        {
            db.AccountsTables.Add(myAccount);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Accounts/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] AccountsTable myAccount)
        {
            
        }

        // DELETE: api/Accounts/5
        [HttpDelete("{id} ")]
        public ActionResult<AccountsTable> Delete(string id)
        {
            var foundAccount = db.AccountsTables.FirstOrDefault(a => a.AccountId == id);
            db.AccountsTables.Remove(foundAccount);
            db.SaveChanges();
            return StatusCode(201);
        }
        
    }
}
