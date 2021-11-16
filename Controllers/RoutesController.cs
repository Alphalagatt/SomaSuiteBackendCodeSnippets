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
    public class RoutesController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public RoutesController(myDBContext _db)
        {
            db = _db;
        }
        */

        // GET: api/Routes
        [HttpGet]
        public ActionResult<RoutesTable> Get()
        {
            return Ok(db.RoutesTables.Include(r=>r.RoutesVehicles));
        }

        // GET: api/Routes/5
        [HttpGet("{id}", Name = "GetRoutes")]
        public ActionResult<RoutesTable> Get(int id)
        {
            return Ok(db.RoutesTables.Include(r => r.RoutesVehicles).FirstOrDefault(r => r.RouteId == id));
        }

        // POST: api/Routes
        [HttpPost]
        public ActionResult<RoutesTable> Post([FromBody] RoutesTable routes)
        {
            db.RoutesTables.Add(routes);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Routes/5
        [HttpPut("{id}")]
        public ActionResult<RoutesTable> Put(int id, [FromBody] RoutesTable routes)
        {
            var foundRoute = db.RoutesTables.FirstOrDefault(r => r.RouteId == id);
            foundRoute.RouteName = routes.RouteName;
            foundRoute.PricePerMonth = routes.PricePerMonth;
            foundRoute.TimeOfCollection = routes.TimeOfCollection;
            db.SaveChanges();
            return Accepted();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<RoutesTable> Delete(int id)
        {
            var foundRoute = db.RoutesTables.FirstOrDefault(r => r.RouteId == id);
            db.RoutesTables.Remove(foundRoute);
            db.SaveChanges();
            return Accepted();
        }
    }
}
