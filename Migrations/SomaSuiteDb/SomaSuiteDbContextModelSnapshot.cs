﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SomaSuiteBackEnd.TestModels;

namespace SomaSuiteBackEnd.Migrations.SomaSuiteDb
{
    [DbContext(typeof(SomaSuiteDbContext))]
    partial class SomaSuiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.AccountsTable", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AccountID");

                    b.HasKey("AccountId");

                    b.ToTable("AccountsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.DisbursmentDetailsTable", b =>
                {
                    b.Property<int>("DisbursmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("disbursmentID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DisbursmentsDisbursmentRecordId")
                        .HasColumnType("int")
                        .HasColumnName("DisbursmentsDisbursmentRecordID");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    b.Property<int>("StructureId")
                        .HasColumnType("int")
                        .HasColumnName("StructureID");

                    b.HasKey("DisbursmentId");

                    b.HasIndex(new[] { "AccountNumber" }, "IX_DisbursmentDetailsTable_AccountNumber");

                    b.HasIndex(new[] { "DisbursmentsDisbursmentRecordId" }, "IX_DisbursmentDetailsTable_DisbursmentsDisbursmentRecordID");

                    b.HasIndex(new[] { "StructureId" }, "IX_DisbursmentDetailsTable_StructureID");

                    b.ToTable("DisbursmentDetailsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.DisbursmentsTable", b =>
                {
                    b.Property<int>("DisbursmentRecordId")
                        .HasColumnType("int")
                        .HasColumnName("DisbursmentRecordID");

                    b.Property<string>("PupilId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PupilID");

                    b.HasKey("DisbursmentRecordId");

                    b.ToTable("DisbursmentsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradePositionsTable", b =>
                {
                    b.Property<int>("PosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("posID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfGrade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PosId");

                    b.ToTable("GradePositionsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradeStream", b =>
                {
                    b.Property<int>("GradesGradeId")
                        .HasColumnType("int")
                        .HasColumnName("GradesGradeID");

                    b.Property<int>("StreamsStreamId")
                        .HasColumnType("int")
                        .HasColumnName("StreamsStreamID");

                    b.HasKey("GradesGradeId", "StreamsStreamId");

                    b.HasIndex(new[] { "StreamsStreamId" }, "IX_GradeStream_StreamsStreamID");

                    b.ToTable("GradeStream");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradeTable", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PosId")
                        .HasColumnType("int")
                        .HasColumnName("posID");

                    b.HasKey("GradeId");

                    b.HasIndex(new[] { "PosId" }, "IX_GradeTable_posID");

                    b.ToTable("GradeTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GuardiansPupil", b =>
                {
                    b.Property<string>("GuardiansNationalId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("GuardiansNationalID");

                    b.Property<string>("PupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GuardiansNationalId", "PupilRegNo");

                    b.HasIndex(new[] { "PupilRegNo" }, "IX_GuardiansPupils_PupilRegNo");

                    b.ToTable("GuardiansPupils");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GuardiansTable", b =>
                {
                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("NationalID");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2")
                        .HasColumnName("DOB");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalId");

                    b.ToTable("GuardiansTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.HealthTable", b =>
                {
                    b.Property<int>("HealthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HealthID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disabilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongTermConditions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HealthId");

                    b.ToTable("HealthTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PaymentRecordsTable", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("PaymentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeOfPayment")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("PaymentId");

                    b.HasIndex(new[] { "AccountNumber" }, "IX_PaymentRecordsTable_AccountNumber");

                    b.ToTable("PaymentRecordsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PupilsStructure", b =>
                {
                    b.Property<string>("AllPupilsPupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PaymentStructuresStructureId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentStructuresStructureID");

                    b.HasKey("AllPupilsPupilRegNo", "PaymentStructuresStructureId");

                    b.HasIndex(new[] { "PaymentStructuresStructureId" }, "IX_PupilsStructures_PaymentStructuresStructureID");

                    b.ToTable("PupilsStructures");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PupilsTable", b =>
                {
                    b.Property<string>("PupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Doa")
                        .HasColumnType("datetime2")
                        .HasColumnName("DOA");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2")
                        .HasColumnName("DOB");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradeId")
                        .HasColumnType("int")
                        .HasColumnName("GradeID");

                    b.Property<int?>("HealthId")
                        .HasColumnType("int")
                        .HasColumnName("HealthID");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PupilFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreamId")
                        .HasColumnType("int")
                        .HasColumnName("StreamID");

                    b.HasKey("PupilRegNo");

                    b.HasIndex(new[] { "GradeId" }, "IX_PupilsTable_GradeID");

                    b.HasIndex(new[] { "HealthId" }, "IX_PupilsTable_HealthID");

                    b.HasIndex(new[] { "StreamId" }, "IX_PupilsTable_StreamID");

                    b.ToTable("PupilsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoleStaff", b =>
                {
                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int")
                        .HasColumnName("RolesRoleID");

                    b.Property<string>("StaffsStaffId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("StaffsStaffID");

                    b.HasKey("RolesRoleId", "StaffsStaffId");

                    b.HasIndex(new[] { "StaffsStaffId" }, "IX_RoleStaff_StaffsStaffID");

                    b.ToTable("RoleStaff");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RolesTable", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("RolesTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoutesTable", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("routeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PricePerMonth")
                        .HasColumnType("int");

                    b.Property<string>("RouteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfCollection")
                        .HasColumnType("datetime2")
                        .HasColumnName("timeOfCollection");

                    b.HasKey("RouteId");

                    b.ToTable("RoutesTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoutesVehicle", b =>
                {
                    b.Property<int>("RoutesAccessedrouteId")
                        .HasColumnType("int")
                        .HasColumnName("RoutesAccessedrouteID");

                    b.Property<string>("VehiclesVehicleRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoutesAccessedrouteId", "VehiclesVehicleRegNo");

                    b.HasIndex(new[] { "VehiclesVehicleRegNo" }, "IX_RoutesVehicles_VehiclesVehicleRegNo");

                    b.ToTable("RoutesVehicles");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StaffTable", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("StaffID");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdno")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalIDNo");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.ToTable("StaffTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StreamTable", b =>
                {
                    b.Property<int>("StreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StreamID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StreamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreamId");

                    b.ToTable("StreamTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StructureDetailsTable", b =>
                {
                    b.Property<int>("StructureDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StructureDetailsID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("DetailName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StructuresStructureId")
                        .HasColumnType("int")
                        .HasColumnName("StructuresStructureID");

                    b.HasKey("StructureDetailsId");

                    b.HasIndex(new[] { "StructuresStructureId" }, "IX_StructureDetailsTable_StructuresStructureID");

                    b.ToTable("StructureDetailsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StructuresTable", b =>
                {
                    b.Property<int>("StructureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StructureID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StructureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StructureId");

                    b.ToTable("StructuresTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.TransportSubscription", b =>
                {
                    b.Property<int>("SubscritionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubscritionID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfTripsAday")
                        .HasColumnType("int")
                        .HasColumnName("NumberOfTripsADay");

                    b.Property<string>("PupilsId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PupilsID");

                    b.Property<int>("RouteId")
                        .HasColumnType("int")
                        .HasColumnName("RouteID");

                    b.Property<int>("SubscriptionDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscritionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscritionId");

                    b.HasIndex(new[] { "PupilsId" }, "IX_TransportSubscriptions_PupilsID");

                    b.HasIndex(new[] { "RouteId" }, "IX_TransportSubscriptions_RouteID");

                    b.ToTable("TransportSubscriptions");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.VehiclesTable", b =>
                {
                    b.Property<string>("VehicleRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Attendant")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CarringCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleRegNo");

                    b.HasIndex(new[] { "Attendant" }, "IX_VehiclesTable_Attendant");

                    b.HasIndex(new[] { "Driver" }, "IX_VehiclesTable_Driver");

                    b.ToTable("VehiclesTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.AccountsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.PupilsTable", "Account")
                        .WithOne("AccountsTable")
                        .HasForeignKey("SomaSuiteBackEnd.TestModels.AccountsTable", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.DisbursmentDetailsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.AccountsTable", "AccountNumberNavigation")
                        .WithMany("DisbursmentDetailsTables")
                        .HasForeignKey("AccountNumber");

                    b.HasOne("SomaSuiteBackEnd.TestModels.DisbursmentsTable", "DisbursmentsDisbursmentRecord")
                        .WithMany("DisbursmentDetailsTables")
                        .HasForeignKey("DisbursmentsDisbursmentRecordId");

                    b.HasOne("SomaSuiteBackEnd.TestModels.StructuresTable", "Structure")
                        .WithMany("DisbursmentDetailsTables")
                        .HasForeignKey("StructureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountNumberNavigation");

                    b.Navigation("DisbursmentsDisbursmentRecord");

                    b.Navigation("Structure");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.DisbursmentsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.PaymentRecordsTable", "DisbursmentRecord")
                        .WithOne("DisbursmentsTable")
                        .HasForeignKey("SomaSuiteBackEnd.TestModels.DisbursmentsTable", "DisbursmentRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DisbursmentRecord");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradeStream", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.GradeTable", "GradesGrade")
                        .WithMany("GradeStreams")
                        .HasForeignKey("GradesGradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.TestModels.StreamTable", "StreamsStream")
                        .WithMany("GradeStreams")
                        .HasForeignKey("StreamsStreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GradesGrade");

                    b.Navigation("StreamsStream");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradeTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.GradePositionsTable", "Pos")
                        .WithMany("GradeTables")
                        .HasForeignKey("PosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pos");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GuardiansPupil", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.GuardiansTable", "GuardiansNational")
                        .WithMany("GuardiansPupils")
                        .HasForeignKey("GuardiansNationalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.TestModels.PupilsTable", "PupilRegNoNavigation")
                        .WithMany("GuardiansPupils")
                        .HasForeignKey("PupilRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GuardiansNational");

                    b.Navigation("PupilRegNoNavigation");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PaymentRecordsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.AccountsTable", "AccountNumberNavigation")
                        .WithMany("PaymentRecordsTables")
                        .HasForeignKey("AccountNumber");

                    b.Navigation("AccountNumberNavigation");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PupilsStructure", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.PupilsTable", "AllPupilsPupilRegNoNavigation")
                        .WithMany("PupilsStructures")
                        .HasForeignKey("AllPupilsPupilRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.TestModels.StructuresTable", "PaymentStructuresStructure")
                        .WithMany("PupilsStructures")
                        .HasForeignKey("PaymentStructuresStructureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllPupilsPupilRegNoNavigation");

                    b.Navigation("PaymentStructuresStructure");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PupilsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.GradeTable", "Grade")
                        .WithMany("PupilsTables")
                        .HasForeignKey("GradeId");

                    b.HasOne("SomaSuiteBackEnd.TestModels.HealthTable", "Health")
                        .WithMany("PupilsTables")
                        .HasForeignKey("HealthId");

                    b.HasOne("SomaSuiteBackEnd.TestModels.StreamTable", "Stream")
                        .WithMany("PupilsTables")
                        .HasForeignKey("StreamId");

                    b.Navigation("Grade");

                    b.Navigation("Health");

                    b.Navigation("Stream");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoleStaff", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.RolesTable", "RolesRole")
                        .WithMany("RoleStaffs")
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.TestModels.StaffTable", "StaffsStaff")
                        .WithMany("RoleStaffs")
                        .HasForeignKey("StaffsStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolesRole");

                    b.Navigation("StaffsStaff");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoutesVehicle", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.RoutesTable", "RoutesAccessedroute")
                        .WithMany("RoutesVehicles")
                        .HasForeignKey("RoutesAccessedrouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.TestModels.VehiclesTable", "VehiclesVehicleRegNoNavigation")
                        .WithMany("RoutesVehicles")
                        .HasForeignKey("VehiclesVehicleRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoutesAccessedroute");

                    b.Navigation("VehiclesVehicleRegNoNavigation");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StructureDetailsTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.StructuresTable", "StructuresStructure")
                        .WithMany("StructureDetailsTables")
                        .HasForeignKey("StructuresStructureId");

                    b.Navigation("StructuresStructure");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.TransportSubscription", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.PupilsTable", "Pupils")
                        .WithMany("TransportSubscriptions")
                        .HasForeignKey("PupilsId");

                    b.HasOne("SomaSuiteBackEnd.TestModels.RoutesTable", "Route")
                        .WithMany("TransportSubscriptions")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupils");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.VehiclesTable", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.TestModels.StaffTable", "AttendantNavigation")
                        .WithMany("VehiclesTableAttendantNavigations")
                        .HasForeignKey("Attendant");

                    b.HasOne("SomaSuiteBackEnd.TestModels.StaffTable", "DriverNavigation")
                        .WithMany("VehiclesTableDriverNavigations")
                        .HasForeignKey("Driver");

                    b.Navigation("AttendantNavigation");

                    b.Navigation("DriverNavigation");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.AccountsTable", b =>
                {
                    b.Navigation("DisbursmentDetailsTables");

                    b.Navigation("PaymentRecordsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.DisbursmentsTable", b =>
                {
                    b.Navigation("DisbursmentDetailsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradePositionsTable", b =>
                {
                    b.Navigation("GradeTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GradeTable", b =>
                {
                    b.Navigation("GradeStreams");

                    b.Navigation("PupilsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.GuardiansTable", b =>
                {
                    b.Navigation("GuardiansPupils");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.HealthTable", b =>
                {
                    b.Navigation("PupilsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PaymentRecordsTable", b =>
                {
                    b.Navigation("DisbursmentsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.PupilsTable", b =>
                {
                    b.Navigation("AccountsTable");

                    b.Navigation("GuardiansPupils");

                    b.Navigation("PupilsStructures");

                    b.Navigation("TransportSubscriptions");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RolesTable", b =>
                {
                    b.Navigation("RoleStaffs");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.RoutesTable", b =>
                {
                    b.Navigation("RoutesVehicles");

                    b.Navigation("TransportSubscriptions");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StaffTable", b =>
                {
                    b.Navigation("RoleStaffs");

                    b.Navigation("VehiclesTableAttendantNavigations");

                    b.Navigation("VehiclesTableDriverNavigations");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StreamTable", b =>
                {
                    b.Navigation("GradeStreams");

                    b.Navigation("PupilsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.StructuresTable", b =>
                {
                    b.Navigation("DisbursmentDetailsTables");

                    b.Navigation("PupilsStructures");

                    b.Navigation("StructureDetailsTables");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.TestModels.VehiclesTable", b =>
                {
                    b.Navigation("RoutesVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
