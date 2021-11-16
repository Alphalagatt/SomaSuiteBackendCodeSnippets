﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SomaSuiteBackEnd.Data;

namespace SomaSuiteBackEnd.Migrations
{
    [DbContext(typeof(myDBContext))]
    partial class myDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GradeStream", b =>
                {
                    b.Property<int>("GradesGradeID")
                        .HasColumnType("int");

                    b.Property<int>("StreamsStreamID")
                        .HasColumnType("int");

                    b.HasKey("GradesGradeID", "StreamsStreamID");

                    b.HasIndex("StreamsStreamID");

                    b.ToTable("GradeStream");
                });

            modelBuilder.Entity("GuardiansPupils", b =>
                {
                    b.Property<string>("GuardiansNationalID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GuardiansNationalID", "PupilRegNo");

                    b.HasIndex("PupilRegNo");

                    b.ToTable("GuardiansPupils");
                });

            modelBuilder.Entity("PupilsStructures", b =>
                {
                    b.Property<string>("AllPupilsPupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PaymentStructuresStructureID")
                        .HasColumnType("int");

                    b.HasKey("AllPupilsPupilRegNo", "PaymentStructuresStructureID");

                    b.HasIndex("PaymentStructuresStructureID");

                    b.ToTable("PupilsStructures");
                });

            modelBuilder.Entity("RoleStaff", b =>
                {
                    b.Property<int>("RolesRoleID")
                        .HasColumnType("int");

                    b.Property<string>("StaffsStaffID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RolesRoleID", "StaffsStaffID");

                    b.HasIndex("StaffsStaffID");

                    b.ToTable("RoleStaff");
                });

            modelBuilder.Entity("RoutesVehicles", b =>
                {
                    b.Property<int>("RoutesAccessedrouteID")
                        .HasColumnType("int");

                    b.Property<string>("VehiclesVehicleRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoutesAccessedrouteID", "VehiclesVehicleRegNo");

                    b.HasIndex("VehiclesVehicleRegNo");

                    b.ToTable("RoutesVehicles");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Accounts", b =>
                {
                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountID");

                    b.ToTable("AccountsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.DisbursmentDetails", b =>
                {
                    b.Property<int>("disbursmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DisbursmentsDisbursmentRecordID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("StructureID")
                        .HasColumnType("int");

                    b.HasKey("disbursmentID");

                    b.HasIndex("AccountNumber");

                    b.HasIndex("DisbursmentsDisbursmentRecordID");

                    b.HasIndex("StructureID");

                    b.ToTable("DisbursmentDetailsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Disbursments", b =>
                {
                    b.Property<int>("DisbursmentRecordID")
                        .HasColumnType("int");

                    b.Property<string>("PupilID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisbursmentRecordID");

                    b.ToTable("DisbursmentsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("posID")
                        .HasColumnType("int");

                    b.HasKey("GradeID");

                    b.HasIndex("posID");

                    b.ToTable("GradeTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.GradePositions", b =>
                {
                    b.Property<int>("posID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfGrade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("posID");

                    b.ToTable("GradePositionsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Guardians", b =>
                {
                    b.Property<string>("NationalID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalID");

                    b.ToTable("GuardiansTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Health", b =>
                {
                    b.Property<int>("HealthID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
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

                    b.HasKey("HealthID");

                    b.ToTable("HealthTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.PaymentRecords", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
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

                    b.HasKey("PaymentID");

                    b.HasIndex("AccountNumber");

                    b.ToTable("PaymentRecordsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Pupils", b =>
                {
                    b.Property<string>("PupilRegNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DOA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradeID")
                        .HasColumnType("int");

                    b.Property<int?>("HealthID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PupilFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreamID")
                        .HasColumnType("int");

                    b.HasKey("PupilRegNo");

                    b.HasIndex("GradeID");

                    b.HasIndex("HealthID");

                    b.HasIndex("StreamID");

                    b.ToTable("PupilsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("RolesTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Routes", b =>
                {
                    b.Property<int>("routeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PricePerMonth")
                        .HasColumnType("int");

                    b.Property<string>("RouteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("timeOfCollection")
                        .HasColumnType("datetime2");

                    b.HasKey("routeID");

                    b.ToTable("RoutesTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIDNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.ToTable("StaffTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Stream", b =>
                {
                    b.Property<int>("StreamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StreamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreamID");

                    b.ToTable("StreamTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.StructureDetails", b =>
                {
                    b.Property<int>("StructureDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("DetailName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StructuresStructureID")
                        .HasColumnType("int");

                    b.HasKey("StructureDetailsID");

                    b.HasIndex("StructuresStructureID");

                    b.ToTable("StructureDetailsTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Structures", b =>
                {
                    b.Property<int>("StructureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StructureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StructureID");

                    b.ToTable("StructuresTable");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.TransportSubscription", b =>
                {
                    b.Property<int>("SubscritionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfTripsADay")
                        .HasColumnType("int");

                    b.Property<string>("PupilsID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RouteID")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscritionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscritionID");

                    b.HasIndex("PupilsID");

                    b.HasIndex("RouteID");

                    b.ToTable("TransportSubscriptions");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Vehicles", b =>
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

                    b.HasIndex("Attendant");

                    b.HasIndex("Driver");

                    b.ToTable("VehiclesTable");
                });

            modelBuilder.Entity("GradeStream", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Grade", null)
                        .WithMany()
                        .HasForeignKey("GradesGradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.Models.Stream", null)
                        .WithMany()
                        .HasForeignKey("StreamsStreamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuardiansPupils", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Guardians", null)
                        .WithMany()
                        .HasForeignKey("GuardiansNationalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.Models.Pupils", null)
                        .WithMany()
                        .HasForeignKey("PupilRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PupilsStructures", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Pupils", null)
                        .WithMany()
                        .HasForeignKey("AllPupilsPupilRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.Models.Structures", null)
                        .WithMany()
                        .HasForeignKey("PaymentStructuresStructureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleStaff", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("StaffsStaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoutesVehicles", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Routes", null)
                        .WithMany()
                        .HasForeignKey("RoutesAccessedrouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SomaSuiteBackEnd.Models.Vehicles", null)
                        .WithMany()
                        .HasForeignKey("VehiclesVehicleRegNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Accounts", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Pupils", "Pupil")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.DisbursmentDetails", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Accounts", "Account")
                        .WithMany("AllDisbursments")
                        .HasForeignKey("AccountNumber");

                    b.HasOne("SomaSuiteBackEnd.Models.Disbursments", null)
                        .WithMany("DisbursmentDetail")
                        .HasForeignKey("DisbursmentsDisbursmentRecordID");

                    b.HasOne("SomaSuiteBackEnd.Models.Structures", "Cartegory")
                        .WithMany()
                        .HasForeignKey("StructureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Cartegory");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Disbursments", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.PaymentRecords", "PaymentRecord")
                        .WithMany()
                        .HasForeignKey("DisbursmentRecordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentRecord");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Grade", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.GradePositions", "CurrentYearsClass")
                        .WithMany()
                        .HasForeignKey("posID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentYearsClass");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.PaymentRecords", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Accounts", "Account")
                        .WithMany("AllPayments")
                        .HasForeignKey("AccountNumber");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Pupils", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Grade", "PupilsGrade")
                        .WithMany("PupilsOfClass")
                        .HasForeignKey("GradeID");

                    b.HasOne("SomaSuiteBackEnd.Models.Health", "HealthConditions")
                        .WithMany()
                        .HasForeignKey("HealthID");

                    b.HasOne("SomaSuiteBackEnd.Models.Stream", "PupilsStream")
                        .WithMany()
                        .HasForeignKey("StreamID");

                    b.Navigation("HealthConditions");

                    b.Navigation("PupilsGrade");

                    b.Navigation("PupilsStream");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.StructureDetails", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Structures", null)
                        .WithMany("Details")
                        .HasForeignKey("StructuresStructureID");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.TransportSubscription", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Pupils", "Pupil")
                        .WithMany()
                        .HasForeignKey("PupilsID");

                    b.HasOne("SomaSuiteBackEnd.Models.Routes", "Route")
                        .WithMany()
                        .HasForeignKey("RouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Vehicles", b =>
                {
                    b.HasOne("SomaSuiteBackEnd.Models.Staff", "Staff2")
                        .WithMany()
                        .HasForeignKey("Attendant");

                    b.HasOne("SomaSuiteBackEnd.Models.Staff", "Staff1")
                        .WithMany()
                        .HasForeignKey("Driver");

                    b.Navigation("Staff1");

                    b.Navigation("Staff2");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Accounts", b =>
                {
                    b.Navigation("AllDisbursments");

                    b.Navigation("AllPayments");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Disbursments", b =>
                {
                    b.Navigation("DisbursmentDetail");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Grade", b =>
                {
                    b.Navigation("PupilsOfClass");
                });

            modelBuilder.Entity("SomaSuiteBackEnd.Models.Structures", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
