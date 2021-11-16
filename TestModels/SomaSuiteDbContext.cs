using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SomaSuiteBackEnd.TestModels
{
    public partial class SomaSuiteDbContext : DbContext
    {
        public SomaSuiteDbContext()
        {
        }

        public SomaSuiteDbContext(DbContextOptions<SomaSuiteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountsTable> AccountsTables { get; set; }
        public virtual DbSet<DisbursmentDetailsTable> DisbursmentDetailsTables { get; set; }
        public virtual DbSet<DisbursmentsTable> DisbursmentsTables { get; set; }
        public virtual DbSet<GradePositionsTable> GradePositionsTables { get; set; }
        public virtual DbSet<GradeStream> GradeStreams { get; set; }
        public virtual DbSet<GradeTable> GradeTables { get; set; }
        public virtual DbSet<GuardiansPupil> GuardiansPupils { get; set; }
        public virtual DbSet<GuardiansTable> GuardiansTables { get; set; }
        public virtual DbSet<HealthTable> HealthTables { get; set; }
        public virtual DbSet<PaymentRecordsTable> PaymentRecordsTables { get; set; }
        public virtual DbSet<PupilsStructure> PupilsStructures { get; set; }
        public virtual DbSet<PupilsTable> PupilsTables { get; set; }
        public virtual DbSet<RoleStaff> RoleStaffs { get; set; }
        public virtual DbSet<RolesTable> RolesTables { get; set; }
        public virtual DbSet<RoutesTable> RoutesTables { get; set; }
        public virtual DbSet<RoutesVehicle> RoutesVehicles { get; set; }
        public virtual DbSet<StaffTable> StaffTables { get; set; }
        public virtual DbSet<StreamTable> StreamTables { get; set; }
        public virtual DbSet<StructureDetailsTable> StructureDetailsTables { get; set; }
        public virtual DbSet<StructuresTable> StructuresTables { get; set; }
        public virtual DbSet<TransportSubscription> TransportSubscriptions { get; set; }
        public virtual DbSet<VehiclesTable> VehiclesTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB;initial catalog=SomaSuiteDb;integrated security=true");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountsTable>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("AccountsTable");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.AccountsTable)
                    .HasForeignKey<AccountsTable>(d => d.AccountId);
            });

            modelBuilder.Entity<DisbursmentDetailsTable>(entity =>
            {
                entity.HasKey(e => e.DisbursmentId);

                entity.ToTable("DisbursmentDetailsTable");

                entity.HasIndex(e => e.AccountNumber, "IX_DisbursmentDetailsTable_AccountNumber");

                entity.HasIndex(e => e.DisbursmentsDisbursmentRecordId, "IX_DisbursmentDetailsTable_DisbursmentsDisbursmentRecordID");

                entity.HasIndex(e => e.StructureId, "IX_DisbursmentDetailsTable_StructureID");

                entity.Property(e => e.DisbursmentId).HasColumnName("disbursmentID");

                entity.Property(e => e.DisbursmentsDisbursmentRecordId).HasColumnName("DisbursmentsDisbursmentRecordID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.StructureId).HasColumnName("StructureID");

                entity.HasOne(d => d.AccountNumberNavigation)
                    .WithMany(p => p.DisbursmentDetailsTables)
                    .HasForeignKey(d => d.AccountNumber);

                entity.HasOne(d => d.DisbursmentsDisbursmentRecord)
                    .WithMany(p => p.DisbursmentDetailsTables)
                    .HasForeignKey(d => d.DisbursmentsDisbursmentRecordId);

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.DisbursmentDetailsTables)
                    .HasForeignKey(d => d.StructureId);
            });

            modelBuilder.Entity<DisbursmentsTable>(entity =>
            {
                entity.HasKey(e => e.DisbursmentRecordId);

                entity.ToTable("DisbursmentsTable");

                entity.Property(e => e.DisbursmentRecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("DisbursmentRecordID");

                entity.Property(e => e.PupilId).HasColumnName("PupilID");

                entity.HasOne(d => d.DisbursmentRecord)
                    .WithOne(p => p.DisbursmentsTable)
                    .HasForeignKey<DisbursmentsTable>(d => d.DisbursmentRecordId);
            });

            modelBuilder.Entity<GradePositionsTable>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("GradePositionsTable");

                entity.Property(e => e.PosId).HasColumnName("posID");
            });

            modelBuilder.Entity<GradeStream>(entity =>
            {
                entity.HasKey(e => new { e.GradesGradeId, e.StreamsStreamId });

                entity.ToTable("GradeStream");

                entity.HasIndex(e => e.StreamsStreamId, "IX_GradeStream_StreamsStreamID");

                entity.Property(e => e.GradesGradeId).HasColumnName("GradesGradeID");

                entity.Property(e => e.StreamsStreamId).HasColumnName("StreamsStreamID");

                entity.HasOne(d => d.GradesGrade)
                    .WithMany(p => p.GradeStreams)
                    .HasForeignKey(d => d.GradesGradeId);

                entity.HasOne(d => d.StreamsStream)
                    .WithMany(p => p.GradeStreams)
                    .HasForeignKey(d => d.StreamsStreamId);
            });

            modelBuilder.Entity<GradeTable>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("GradeTable");

                entity.HasIndex(e => e.PosId, "IX_GradeTable_posID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.PosId).HasColumnName("posID");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.GradeTables)
                    .HasForeignKey(d => d.PosId);
            });

            modelBuilder.Entity<GuardiansPupil>(entity =>
            {
                entity.HasKey(e => new { e.GuardiansNationalId, e.PupilRegNo });

                entity.HasIndex(e => e.PupilRegNo, "IX_GuardiansPupils_PupilRegNo");

                entity.Property(e => e.GuardiansNationalId).HasColumnName("GuardiansNationalID");

                entity.HasOne(d => d.GuardiansNational)
                    .WithMany(p => p.GuardiansPupils)
                    .HasForeignKey(d => d.GuardiansNationalId);

                entity.HasOne(d => d.PupilRegNoNavigation)
                    .WithMany(p => p.GuardiansPupils)
                    .HasForeignKey(d => d.PupilRegNo);
            });

            modelBuilder.Entity<GuardiansTable>(entity =>
            {
                entity.HasKey(e => e.NationalId);

                entity.ToTable("GuardiansTable");

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.Dob).HasColumnName("DOB");
            });

            modelBuilder.Entity<HealthTable>(entity =>
            {
                entity.HasKey(e => e.HealthId);

                entity.ToTable("HealthTable");

                entity.Property(e => e.HealthId).HasColumnName("HealthID");

                entity.Property(e => e.Allergies).IsRequired();

                entity.Property(e => e.BloodGroup).IsRequired();

                entity.Property(e => e.Disabilities).IsRequired();

                entity.Property(e => e.LongTermConditions).IsRequired();
            });

            modelBuilder.Entity<PaymentRecordsTable>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("PaymentRecordsTable");

                entity.HasIndex(e => e.AccountNumber, "IX_PaymentRecordsTable_AccountNumber");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.TimeOfPayment)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AccountNumberNavigation)
                    .WithMany(p => p.PaymentRecordsTables)
                    .HasForeignKey(d => d.AccountNumber);
            });

            modelBuilder.Entity<PupilsStructure>(entity =>
            {
                entity.HasKey(e => new { e.AllPupilsPupilRegNo, e.PaymentStructuresStructureId });

                entity.HasIndex(e => e.PaymentStructuresStructureId, "IX_PupilsStructures_PaymentStructuresStructureID");

                entity.Property(e => e.PaymentStructuresStructureId).HasColumnName("PaymentStructuresStructureID");

                entity.HasOne(d => d.AllPupilsPupilRegNoNavigation)
                    .WithMany(p => p.PupilsStructures)
                    .HasForeignKey(d => d.AllPupilsPupilRegNo);

                entity.HasOne(d => d.PaymentStructuresStructure)
                    .WithMany(p => p.PupilsStructures)
                    .HasForeignKey(d => d.PaymentStructuresStructureId);
            });

            modelBuilder.Entity<PupilsTable>(entity =>
            {
                entity.HasKey(e => e.PupilRegNo);

                entity.ToTable("PupilsTable");

                entity.HasIndex(e => e.GradeId, "IX_PupilsTable_GradeID");

                entity.HasIndex(e => e.HealthId, "IX_PupilsTable_HealthID");

                entity.HasIndex(e => e.StreamId, "IX_PupilsTable_StreamID");

                entity.Property(e => e.Doa).HasColumnName("DOA");

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.HealthId).HasColumnName("HealthID");

                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.PupilsTables)
                    .HasForeignKey(d => d.GradeId);

                entity.HasOne(d => d.Health)
                    .WithMany(p => p.PupilsTables)
                    .HasForeignKey(d => d.HealthId);

                entity.HasOne(d => d.Stream)
                    .WithMany(p => p.PupilsTables)
                    .HasForeignKey(d => d.StreamId);
            });

            modelBuilder.Entity<RoleStaff>(entity =>
            {
                entity.HasKey(e => new { e.RolesRoleId, e.StaffsStaffId });

                entity.ToTable("RoleStaff");

                entity.HasIndex(e => e.StaffsStaffId, "IX_RoleStaff_StaffsStaffID");

                entity.Property(e => e.RolesRoleId).HasColumnName("RolesRoleID");

                entity.Property(e => e.StaffsStaffId).HasColumnName("StaffsStaffID");

                entity.HasOne(d => d.RolesRole)
                    .WithMany(p => p.RoleStaffs)
                    .HasForeignKey(d => d.RolesRoleId);

                entity.HasOne(d => d.StaffsStaff)
                    .WithMany(p => p.RoleStaffs)
                    .HasForeignKey(d => d.StaffsStaffId);
            });

            modelBuilder.Entity<RolesTable>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("RolesTable");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.RoleName).IsRequired();
            });

            modelBuilder.Entity<RoutesTable>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("RoutesTable");

                entity.Property(e => e.RouteId).HasColumnName("routeID");

                entity.Property(e => e.TimeOfCollection).HasColumnName("timeOfCollection");
            });

            modelBuilder.Entity<RoutesVehicle>(entity =>
            {
                entity.HasKey(e => new { e.RoutesAccessedrouteId, e.VehiclesVehicleRegNo });

                entity.HasIndex(e => e.VehiclesVehicleRegNo, "IX_RoutesVehicles_VehiclesVehicleRegNo");

                entity.Property(e => e.RoutesAccessedrouteId).HasColumnName("RoutesAccessedrouteID");

                entity.HasOne(d => d.RoutesAccessedroute)
                    .WithMany(p => p.RoutesVehicles)
                    .HasForeignKey(d => d.RoutesAccessedrouteId);

                entity.HasOne(d => d.VehiclesVehicleRegNoNavigation)
                    .WithMany(p => p.RoutesVehicles)
                    .HasForeignKey(d => d.VehiclesVehicleRegNo);
            });

            modelBuilder.Entity<StaffTable>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("StaffTable");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.NationalIdno).HasColumnName("NationalIDNo");
            });

            modelBuilder.Entity<StreamTable>(entity =>
            {
                entity.HasKey(e => e.StreamId);

                entity.ToTable("StreamTable");

                entity.Property(e => e.StreamId).HasColumnName("StreamID");
            });

            modelBuilder.Entity<StructureDetailsTable>(entity =>
            {
                entity.HasKey(e => e.StructureDetailsId);

                entity.ToTable("StructureDetailsTable");

                entity.HasIndex(e => e.StructuresStructureId, "IX_StructureDetailsTable_StructuresStructureID");

                entity.Property(e => e.StructureDetailsId).HasColumnName("StructureDetailsID");

                entity.Property(e => e.StructuresStructureId).HasColumnName("StructuresStructureID");

                entity.HasOne(d => d.StructuresStructure)
                    .WithMany(p => p.StructureDetailsTables)
                    .HasForeignKey(d => d.StructuresStructureId);
            });

            modelBuilder.Entity<StructuresTable>(entity =>
            {
                entity.HasKey(e => e.StructureId);

                entity.ToTable("StructuresTable");

                entity.Property(e => e.StructureId).HasColumnName("StructureID");
            });

            modelBuilder.Entity<TransportSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscritionId);

                entity.HasIndex(e => e.PupilsId, "IX_TransportSubscriptions_PupilsID");

                entity.HasIndex(e => e.RouteId, "IX_TransportSubscriptions_RouteID");

                entity.Property(e => e.SubscritionId).HasColumnName("SubscritionID");

                entity.Property(e => e.NumberOfTripsAday).HasColumnName("NumberOfTripsADay");

                entity.Property(e => e.PupilsId).HasColumnName("PupilsID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.Pupils)
                    .WithMany(p => p.TransportSubscriptions)
                    .HasForeignKey(d => d.PupilsId);

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.TransportSubscriptions)
                    .HasForeignKey(d => d.RouteId);
            });

            modelBuilder.Entity<VehiclesTable>(entity =>
            {
                entity.HasKey(e => e.VehicleRegNo);

                entity.ToTable("VehiclesTable");

                entity.HasIndex(e => e.Attendant, "IX_VehiclesTable_Attendant");

                entity.HasIndex(e => e.Driver, "IX_VehiclesTable_Driver");

                entity.HasOne(d => d.AttendantNavigation)
                    .WithMany(p => p.VehiclesTableAttendantNavigations)
                    .HasForeignKey(d => d.Attendant);

                entity.HasOne(d => d.DriverNavigation)
                    .WithMany(p => p.VehiclesTableDriverNavigations)
                    .HasForeignKey(d => d.Driver);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
