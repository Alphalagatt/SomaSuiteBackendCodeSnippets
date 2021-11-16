using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomaSuiteBackEnd.Data;
//using SomaSuiteBackEnd.Models;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PivotsController : ControllerBase
    {
        SomaSuiteDbContext db = new SomaSuiteDbContext();

       // private readonly myDBContext db;

       // public PivotsController(myDBContext _db)
       // {
       //     db = _db;
       // }


        
        [HttpPost]
        [Route("api/addstaffrole")]
        public ActionResult AddStaffRoleRelationship([FromBody]RoleStaff staffRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.RoleStaffs.Add(staffRole);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/Pivot/5
        [HttpDelete]
        [Route("api/deletestaffrole/{staffID=}/{roleID=}")]
        public ActionResult DeleteStaffRoleRelationship(string staffID, int roleID)
        {
            var foundRelationship = db.RoleStaffs.FirstOrDefault(s => s.StaffsStaffId == staffID && s.RolesRoleId == roleID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.RoleStaffs.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }



        //GuardiansPupil




        [HttpPost]
        [Route("api/addguardianspupil")]
        public ActionResult AddGuardiansPupilRelationship([FromBody] GuardiansPupil guardiansPupil)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.GuardiansPupils.Add(guardiansPupil);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/deleteguardianspupils?pupilID=9801&guardianID=12345678
        [HttpDelete]
        [Route("api/deleteguardianspupils/{pupilID=}/{guardianID=}")]
        public ActionResult DeleteGuardiansPupilRelationship(string pupilID, string guardianID)
        {
            var foundRelationship = db.GuardiansPupils.FirstOrDefault(s => s.PupilRegNo == pupilID && s.GuardiansNationalId == guardianID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.GuardiansPupils.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }





        //StreamGrade






        [HttpPost]
        [Route("api/addstreamgrade")]
        public ActionResult AddStreamGradeRelationship([FromBody]GradeStream streamGrade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.GradeStreams.Add(streamGrade);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/deleteguardianspupils?pupilID=9801&guardianID=12345678
        [HttpDelete]
        [Route("api/deletesteamgrade/{streamID=}/{gradeID=}")]
        public ActionResult DeleteStreamGradeRelationship(int streamID, int gradeID)
        {
            var foundRelationship = db.GradeStreams.FirstOrDefault(s => s.StreamsStreamId == streamID && s.GradesGradeId == gradeID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.GradeStreams.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }


        //Grade Positions

        [HttpPost]
        [Route("api/addgradepos")]
        public ActionResult<GradePositionsTable> AddClassPos([FromBody] GradePositionsTable GradePos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.GradePositionsTables.Add(GradePos);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/deletegradepos?pupilID=9801&guardianID=12345678
        [HttpDelete]
        [Route("api/deletegradepos/{posID=}/{gradeID=}")]
        public ActionResult<GradePositionsTable> DeleteClassPos(int posID, string gradeID)
        {
            var foundRelationship = db.GradePositionsTables.FirstOrDefault(s => s.PosId == posID && s.NameOfGrade == gradeID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.GradePositionsTables.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }



        // pupils structures


        [HttpPost]
        [Route("api/addpupilstructure")]
        public ActionResult<PupilsStructure> AddPupilsStructureRelationship([FromBody] PupilsStructure pupilStructure)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.PupilsStructures.Add(pupilStructure);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/deleteguardianspupils?pupilID=9801&guardianID=12345678
        [HttpDelete]
        [Route("api/deletepupilstructure/{pupilID=}/{structureID=}")]
        public ActionResult<PupilsStructure> DeletePupilStructureRelationship(string pupilID, int structureID)
        {
            var foundRelationship = db.PupilsStructures.FirstOrDefault(s => s.AllPupilsPupilRegNo == pupilID && s.PaymentStructuresStructureId == structureID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.PupilsStructures.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="routesVehicle"></param>
        /// <returns></returns>




        [HttpPost]
        [Route("api/addroutesvehicleRelationship")]
        public ActionResult AddRoutesVehiclesRelationship([FromBody] RoutesVehicle routesVehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("The record you are trying to enter is not valid.");
            }

            db.RoutesVehicles.Add(routesVehicle);
            db.SaveChanges();
            return StatusCode(201);
        }

        // DELETE: api/deleteguardianspupils?pupilID=9801&guardianID=12345678
        [HttpDelete]
        [Route("api/deleteroutesvehicleRelationship/{vehicleRegNo=}/{routeID=}")]
        public ActionResult DeleteRoutesVehicleRelationship(string vehicleRegNo, int routeID)
        {
            var foundRelationship = db.RoutesVehicles.FirstOrDefault(s => s.VehiclesVehicleRegNo == vehicleRegNo && s.RoutesAccessedrouteId == routeID);

            if (foundRelationship == null)
            {
                return NotFound();
            }

            db.RoutesVehicles.Remove(foundRelationship);
            db.SaveChanges();
            return Accepted();

        }







    }
}
