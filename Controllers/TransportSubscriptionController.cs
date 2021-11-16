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
    public class TransportSubscriptionController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public TransportSubscriptionController(myDBContext _db)
        {
            db = _db;
        }
        */


        // GET: api/TransportSubscription
        [HttpGet]
        public ActionResult<TransportSubscription> Get()
        {
            return Ok(db.TransportSubscriptions);
        }

        // GET: api/TransportSubscription/5
        [HttpGet("{id}", Name = "GetSub")]
        public ActionResult<TransportSubscription> Get(int id)
        {
            return Ok(db.TransportSubscriptions.FirstOrDefault(ts => ts.SubscritionId == id));
        }

        // POST: api/TransportSubscription
        [HttpPost]
        public ActionResult<TransportSubscription> Post([FromBody] TransportSubscription sub)
        {
            db.TransportSubscriptions.Add(sub);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/TransportSubscription/5
        [HttpPut("{id}")]
        public ActionResult<TransportSubscription> Put(int id, [FromBody] TransportSubscription TS)
        {
            var foundSub = db.TransportSubscriptions.FirstOrDefault(ts => ts.SubscritionId == id);
            foundSub.RouteId = TS.RouteId;
            foundSub.SubscritionStartDate = TS.SubscritionStartDate;
            foundSub.SubscriptionDuration = TS.SubscriptionDuration;
            foundSub.PupilsId = TS.PupilsId;
            foundSub.NumberOfTripsAday = TS.NumberOfTripsAday;
            db.SaveChanges();

            return Accepted();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<TransportSubscription> Delete(int id)
        {
            var foundSub = db.TransportSubscriptions.FirstOrDefault(ts => ts.SubscritionId == id);
            db.Remove(foundSub);
            db.SaveChanges();
            return Accepted();
        }
    }
}
