using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Data;
using SomaSuiteBackEnd.TestModels;
//using SomaSuiteBackEnd.Models;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        SomaSuiteDbContext db = new SomaSuiteDbContext();

        /*
        private readonly myDBContext db;

        public VehiclesController(myDBContext _db)
        {
            db = _db;
        }
        */

        // GET: api/Vehicles
        [HttpGet]
        public ActionResult<VehiclesTable> Get()
        {
            return Ok(db.VehiclesTables.Include(v=>v.RoutesVehicles));
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}", Name = "GetVehicle")]
        public ActionResult<VehiclesTable> Get(string id)
        {
            return Ok(db.VehiclesTables.Include(v => v.RoutesVehicles).FirstOrDefault(v => v.VehicleRegNo == id));
        }

        // POST: api/Vehicles
        [HttpPost]
        public ActionResult<VehiclesTable> Post([FromBody] VehiclesTable vehicle)
        {
            db.VehiclesTables.Add(vehicle);
            db.SaveChanges();
            return Accepted();
        }

        // PUT: api/Vehicles/5
        [HttpPut("{id}")]
        public ActionResult<VehiclesTable> Put(string id, [FromBody] VehiclesTable vehicle)
        {
            var V = db.VehiclesTables.FirstOrDefault(v => v.VehicleRegNo == id);
            V.VehicleMake = vehicle.VehicleMake;
            V.Model = vehicle.Model;
            V.Driver = vehicle.Driver;
            V.Attendant = vehicle.Attendant;
            V.CarringCapacity = vehicle.CarringCapacity;
            db.SaveChanges();
            return Accepted();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<VehiclesTable> Delete(string id)
        {
            var V = db.VehiclesTables.FirstOrDefault(v => v.VehicleRegNo == id);
            db.VehiclesTables.Remove(V);
            db.SaveChanges();
            return Accepted();

        }
    }
}
