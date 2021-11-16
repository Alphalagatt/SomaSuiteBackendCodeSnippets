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
    public class PaymentRecordsController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();


       // private readonly myDBContext db;

       // public PaymentRecordsController(myDBContext _db)
       // {
         //   db = _db;
       // }


        // GET: api/PaymentRecords
        [HttpGet]
        public ActionResult<PaymentRecordsTable> Get()
        {
            return Ok(db.PaymentRecordsTables);
        }

        // GET: api/PaymentRecords/5
        [HttpGet("{id}", Name = "GetPaymentRecords")]
        public ActionResult<PaymentRecordsTable> Get(string id)
        {
            return Ok(db.PaymentRecordsTables.FirstOrDefault(pr => pr.PaymentCode == id));
        }

        // POST: api/PaymentRecords
        [HttpPost]
        public ActionResult<PaymentRecordsTable> Post([FromBody] PaymentRecordsTable payment)
        {
            db.PaymentRecordsTables.Add(payment);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/PaymentRecords/5
        [HttpPut("{id}")]
        public ActionResult<PaymentRecordsTable> Put(int id, [FromBody] PaymentRecordsTable payment)
        {
            var foundPayment = db.PaymentRecordsTables.FirstOrDefault(pr => pr.PaymentId == id);
            foundPayment.PaymentMethod = payment.PaymentMethod;
            foundPayment.PaymentCode = payment.PaymentCode;
            foundPayment.AccountNumber = payment.AccountNumber;
            foundPayment.Amount = payment.Amount;
            db.SaveChanges();
            return Accepted();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<PaymentRecordsTable> Delete(int id)
        {
            var foundPayment = db.PaymentRecordsTables.FirstOrDefault(pr => pr.PaymentId == id);
            db.PaymentRecordsTables.Remove(foundPayment);
            db.SaveChanges();
            return Accepted();
        }
    }
}
