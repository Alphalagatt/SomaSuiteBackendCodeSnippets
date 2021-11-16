using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SomaSuiteBackEnd.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GradePositionsTable",
                columns: table => new
                {
                    posID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfGrade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradePositionsTable", x => x.posID);
                });

            migrationBuilder.CreateTable(
                name: "GuardiansTable",
                columns: table => new
                {
                    NationalID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuardiansTable", x => x.NationalID);
                });

            migrationBuilder.CreateTable(
                name: "HealthTable",
                columns: table => new
                {
                    HealthID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongTermConditions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthTable", x => x.HealthID);
                });

            migrationBuilder.CreateTable(
                name: "RolesTable",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesTable", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "RoutesTable",
                columns: table => new
                {
                    routeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerMonth = table.Column<int>(type: "int", nullable: false),
                    timeOfCollection = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutesTable", x => x.routeID);
                });

            migrationBuilder.CreateTable(
                name: "StaffTable",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIDNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTable", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "StreamTable",
                columns: table => new
                {
                    StreamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamTable", x => x.StreamID);
                });

            migrationBuilder.CreateTable(
                name: "StructuresTable",
                columns: table => new
                {
                    StructureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StructureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructuresTable", x => x.StructureID);
                });

            migrationBuilder.CreateTable(
                name: "GradeTable",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    posID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeTable", x => x.GradeID);
                    table.ForeignKey(
                        name: "FK_GradeTable_GradePositionsTable_posID",
                        column: x => x.posID,
                        principalTable: "GradePositionsTable",
                        principalColumn: "posID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleStaff",
                columns: table => new
                {
                    RolesRoleID = table.Column<int>(type: "int", nullable: false),
                    StaffsStaffID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleStaff", x => new { x.RolesRoleID, x.StaffsStaffID });
                    table.ForeignKey(
                        name: "FK_RoleStaff_RolesTable_RolesRoleID",
                        column: x => x.RolesRoleID,
                        principalTable: "RolesTable",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleStaff_StaffTable_StaffsStaffID",
                        column: x => x.StaffsStaffID,
                        principalTable: "StaffTable",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehiclesTable",
                columns: table => new
                {
                    VehicleRegNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Attendant = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarringCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclesTable", x => x.VehicleRegNo);
                    table.ForeignKey(
                        name: "FK_VehiclesTable_StaffTable_Attendant",
                        column: x => x.Attendant,
                        principalTable: "StaffTable",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehiclesTable_StaffTable_Driver",
                        column: x => x.Driver,
                        principalTable: "StaffTable",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StructureDetailsTable",
                columns: table => new
                {
                    StructureDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    StructuresStructureID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureDetailsTable", x => x.StructureDetailsID);
                    table.ForeignKey(
                        name: "FK_StructureDetailsTable_StructuresTable_StructuresStructureID",
                        column: x => x.StructuresStructureID,
                        principalTable: "StructuresTable",
                        principalColumn: "StructureID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradeStream",
                columns: table => new
                {
                    GradesGradeID = table.Column<int>(type: "int", nullable: false),
                    StreamsStreamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeStream", x => new { x.GradesGradeID, x.StreamsStreamID });
                    table.ForeignKey(
                        name: "FK_GradeStream_GradeTable_GradesGradeID",
                        column: x => x.GradesGradeID,
                        principalTable: "GradeTable",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradeStream_StreamTable_StreamsStreamID",
                        column: x => x.StreamsStreamID,
                        principalTable: "StreamTable",
                        principalColumn: "StreamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PupilsTable",
                columns: table => new
                {
                    PupilRegNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PupilFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeID = table.Column<int>(type: "int", nullable: true),
                    StreamID = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PupilsTable", x => x.PupilRegNo);
                    table.ForeignKey(
                        name: "FK_PupilsTable_GradeTable_GradeID",
                        column: x => x.GradeID,
                        principalTable: "GradeTable",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PupilsTable_HealthTable_HealthID",
                        column: x => x.HealthID,
                        principalTable: "HealthTable",
                        principalColumn: "HealthID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PupilsTable_StreamTable_StreamID",
                        column: x => x.StreamID,
                        principalTable: "StreamTable",
                        principalColumn: "StreamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoutesVehicles",
                columns: table => new
                {
                    RoutesAccessedrouteID = table.Column<int>(type: "int", nullable: false),
                    VehiclesVehicleRegNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutesVehicles", x => new { x.RoutesAccessedrouteID, x.VehiclesVehicleRegNo });
                    table.ForeignKey(
                        name: "FK_RoutesVehicles_RoutesTable_RoutesAccessedrouteID",
                        column: x => x.RoutesAccessedrouteID,
                        principalTable: "RoutesTable",
                        principalColumn: "routeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutesVehicles_VehiclesTable_VehiclesVehicleRegNo",
                        column: x => x.VehiclesVehicleRegNo,
                        principalTable: "VehiclesTable",
                        principalColumn: "VehicleRegNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountsTable",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsTable", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_AccountsTable_PupilsTable_AccountID",
                        column: x => x.AccountID,
                        principalTable: "PupilsTable",
                        principalColumn: "PupilRegNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuardiansPupils",
                columns: table => new
                {
                    GuardiansNationalID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PupilRegNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuardiansPupils", x => new { x.GuardiansNationalID, x.PupilRegNo });
                    table.ForeignKey(
                        name: "FK_GuardiansPupils_GuardiansTable_GuardiansNationalID",
                        column: x => x.GuardiansNationalID,
                        principalTable: "GuardiansTable",
                        principalColumn: "NationalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuardiansPupils_PupilsTable_PupilRegNo",
                        column: x => x.PupilRegNo,
                        principalTable: "PupilsTable",
                        principalColumn: "PupilRegNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PupilsStructures",
                columns: table => new
                {
                    AllPupilsPupilRegNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentStructuresStructureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PupilsStructures", x => new { x.AllPupilsPupilRegNo, x.PaymentStructuresStructureID });
                    table.ForeignKey(
                        name: "FK_PupilsStructures_PupilsTable_AllPupilsPupilRegNo",
                        column: x => x.AllPupilsPupilRegNo,
                        principalTable: "PupilsTable",
                        principalColumn: "PupilRegNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PupilsStructures_StructuresTable_PaymentStructuresStructureID",
                        column: x => x.PaymentStructuresStructureID,
                        principalTable: "StructuresTable",
                        principalColumn: "StructureID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportSubscriptions",
                columns: table => new
                {
                    SubscritionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteID = table.Column<int>(type: "int", nullable: false),
                    SubscritionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionDuration = table.Column<int>(type: "int", nullable: false),
                    PupilsID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumberOfTripsADay = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportSubscriptions", x => x.SubscritionID);
                    table.ForeignKey(
                        name: "FK_TransportSubscriptions_PupilsTable_PupilsID",
                        column: x => x.PupilsID,
                        principalTable: "PupilsTable",
                        principalColumn: "PupilRegNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportSubscriptions_RoutesTable_RouteID",
                        column: x => x.RouteID,
                        principalTable: "RoutesTable",
                        principalColumn: "routeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRecordsTable",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TimeOfPayment = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRecordsTable", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_PaymentRecordsTable_AccountsTable_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "AccountsTable",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisbursmentsTable",
                columns: table => new
                {
                    DisbursmentRecordID = table.Column<int>(type: "int", nullable: false),
                    PupilID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursmentsTable", x => x.DisbursmentRecordID);
                    table.ForeignKey(
                        name: "FK_DisbursmentsTable_PaymentRecordsTable_DisbursmentRecordID",
                        column: x => x.DisbursmentRecordID,
                        principalTable: "PaymentRecordsTable",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisbursmentDetailsTable",
                columns: table => new
                {
                    disbursmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    StructureID = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DisbursmentsDisbursmentRecordID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursmentDetailsTable", x => x.disbursmentID);
                    table.ForeignKey(
                        name: "FK_DisbursmentDetailsTable_AccountsTable_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "AccountsTable",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisbursmentDetailsTable_DisbursmentsTable_DisbursmentsDisbursmentRecordID",
                        column: x => x.DisbursmentsDisbursmentRecordID,
                        principalTable: "DisbursmentsTable",
                        principalColumn: "DisbursmentRecordID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisbursmentDetailsTable_StructuresTable_StructureID",
                        column: x => x.StructureID,
                        principalTable: "StructuresTable",
                        principalColumn: "StructureID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisbursmentDetailsTable_AccountNumber",
                table: "DisbursmentDetailsTable",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursmentDetailsTable_DisbursmentsDisbursmentRecordID",
                table: "DisbursmentDetailsTable",
                column: "DisbursmentsDisbursmentRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_DisbursmentDetailsTable_StructureID",
                table: "DisbursmentDetailsTable",
                column: "StructureID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeStream_StreamsStreamID",
                table: "GradeStream",
                column: "StreamsStreamID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeTable_posID",
                table: "GradeTable",
                column: "posID");

            migrationBuilder.CreateIndex(
                name: "IX_GuardiansPupils_PupilRegNo",
                table: "GuardiansPupils",
                column: "PupilRegNo");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRecordsTable_AccountNumber",
                table: "PaymentRecordsTable",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PupilsStructures_PaymentStructuresStructureID",
                table: "PupilsStructures",
                column: "PaymentStructuresStructureID");

            migrationBuilder.CreateIndex(
                name: "IX_PupilsTable_GradeID",
                table: "PupilsTable",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_PupilsTable_HealthID",
                table: "PupilsTable",
                column: "HealthID");

            migrationBuilder.CreateIndex(
                name: "IX_PupilsTable_StreamID",
                table: "PupilsTable",
                column: "StreamID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleStaff_StaffsStaffID",
                table: "RoleStaff",
                column: "StaffsStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_RoutesVehicles_VehiclesVehicleRegNo",
                table: "RoutesVehicles",
                column: "VehiclesVehicleRegNo");

            migrationBuilder.CreateIndex(
                name: "IX_StructureDetailsTable_StructuresStructureID",
                table: "StructureDetailsTable",
                column: "StructuresStructureID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportSubscriptions_PupilsID",
                table: "TransportSubscriptions",
                column: "PupilsID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportSubscriptions_RouteID",
                table: "TransportSubscriptions",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesTable_Attendant",
                table: "VehiclesTable",
                column: "Attendant");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesTable_Driver",
                table: "VehiclesTable",
                column: "Driver");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisbursmentDetailsTable");

            migrationBuilder.DropTable(
                name: "GradeStream");

            migrationBuilder.DropTable(
                name: "GuardiansPupils");

            migrationBuilder.DropTable(
                name: "PupilsStructures");

            migrationBuilder.DropTable(
                name: "RoleStaff");

            migrationBuilder.DropTable(
                name: "RoutesVehicles");

            migrationBuilder.DropTable(
                name: "StructureDetailsTable");

            migrationBuilder.DropTable(
                name: "TransportSubscriptions");

            migrationBuilder.DropTable(
                name: "DisbursmentsTable");

            migrationBuilder.DropTable(
                name: "GuardiansTable");

            migrationBuilder.DropTable(
                name: "RolesTable");

            migrationBuilder.DropTable(
                name: "VehiclesTable");

            migrationBuilder.DropTable(
                name: "StructuresTable");

            migrationBuilder.DropTable(
                name: "RoutesTable");

            migrationBuilder.DropTable(
                name: "PaymentRecordsTable");

            migrationBuilder.DropTable(
                name: "StaffTable");

            migrationBuilder.DropTable(
                name: "AccountsTable");

            migrationBuilder.DropTable(
                name: "PupilsTable");

            migrationBuilder.DropTable(
                name: "GradeTable");

            migrationBuilder.DropTable(
                name: "HealthTable");

            migrationBuilder.DropTable(
                name: "StreamTable");

            migrationBuilder.DropTable(
                name: "GradePositionsTable");
        }
    }
}
