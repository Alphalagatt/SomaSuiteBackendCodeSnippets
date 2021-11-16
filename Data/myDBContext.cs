using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SomaSuiteBackEnd.Models;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace SomaSuiteBackEnd.Data
{
    public class myDBContext : DbContext
    {
        public myDBContext(DbContextOptions<myDBContext> opt) : base(opt)
        {

        }

        public DbSet<Pupils> PupilsTable { get; set; }
        public DbSet<Guardians> GuardiansTable { get; set; }
        public DbSet<Staff> StaffTable { get; set; }
        public DbSet<Health> HealthTable { get; set; }
        public DbSet<Role> RolesTable { get; set; }
        public DbSet<Grade> GradeTable { get; set; }
        public DbSet<Stream> StreamTable { get; set; }
        public DbSet<GradePositions> GradePositionsTable { get; set; }
        public DbSet<DisbursmentDetails> DisbursmentDetailsTable { get; set; }
        public DbSet<Disbursments> DisbursmentsTable { get; set; }
        public DbSet<PaymentRecords> PaymentRecordsTable { get; set; }
        public DbSet<Routes> RoutesTable { get; set; }
        public DbSet<StructureDetails> StructureDetailsTable { get; set; }
        public DbSet<Structures> StructuresTable { get; set; }
        public DbSet<Vehicles> VehiclesTable { get; set; }
        public DbSet<Accounts> AccountsTable { get; set; }
        public DbSet<TransportSubscription> TransportSubscriptions { get; set; }


        /// <summary>
        /// pivot tables are created here...
        /// </summary>
       // public DbSet<GuardiansPupils> GuardiansPupils { get; set; }
        //public DbSet<RoleStaff> RoleStaff { get; set; }
        //public DbSet<GradeStream> GradeStream { get; set; }
        //public DbSet<PupilsStructures> PupilsStructures { get; set; }
        //public DbSet<RoutesVehicles> RoutesVehicles { get; set; }




    }
}
