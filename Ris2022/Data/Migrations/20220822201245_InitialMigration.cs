using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ris2022.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acceptancetypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acceptancetypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Cost = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Code = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Martialstatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Martialstatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Aetitle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ipaddress = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Port = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Modalitytypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Departmentid = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalitytypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalitytypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ordetypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordetypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Givenid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Firstname = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    Middlename = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: true),
                    Lastname = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    Gendre = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paytypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paytypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proceduretypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Parentnum = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proceduretypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Orderid = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Patientid = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Imagedate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Referingdoctorid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Raddoctorid = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Physicianid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Reportdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Title = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Meidcalhistory = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Alergy = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Reportbody = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Notes = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    Audiopath = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Parentreport = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Seriesnumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Approved = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Approveddoctorid = table.Column<bool>(type: "NUMBER(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risusers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Username = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pass = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Languageid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Userroleid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Firstname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Lastname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Departmentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Isdoctor = table.Column<bool>(type: "NUMBER(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risusers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Userroles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userroles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worktypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Namear = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nameen = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worktypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Patientid = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Modalityid = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Proceduretypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Studyid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Startdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Enddate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Statusid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Doctorid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Autoexpiredate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Accessionnumber = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Deptid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Documentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ordertypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Insertdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Insertuserid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Reasonid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Updateuserid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Updatedate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Paytypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Payreasonid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Clinicid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Modalitytypeid = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_Departments_Deptid",
                        column: x => x.Deptid,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Modalities_Modality~",
                        column: x => x.Modalityid,
                        principalTable: "Modalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_Modalitytypes_Modal~",
                        column: x => x.Modalitytypeid,
                        principalTable: "Modalitytypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Ordetypes_Ordertype~",
                        column: x => x.Ordertypeid,
                        principalTable: "Ordetypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Patients_Patientid",
                        column: x => x.Patientid,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_Paytypes_Paytypeid",
                        column: x => x.Paytypeid,
                        principalTable: "Paytypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Proceduretypes_Proc~",
                        column: x => x.Proceduretypeid,
                        principalTable: "Proceduretypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Reasons_Reasonid",
                        column: x => x.Reasonid,
                        principalTable: "Reasons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_Deptid",
                table: "orders",
                column: "Deptid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Modalityid",
                table: "orders",
                column: "Modalityid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Modalitytypeid",
                table: "orders",
                column: "Modalitytypeid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Ordertypeid",
                table: "orders",
                column: "Ordertypeid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Patientid",
                table: "orders",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Paytypeid",
                table: "orders",
                column: "Paytypeid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Proceduretypeid",
                table: "orders",
                column: "Proceduretypeid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Reasonid",
                table: "orders",
                column: "Reasonid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acceptancetypes");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Martialstatuses");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Risusers");

            migrationBuilder.DropTable(
                name: "Userroles");

            migrationBuilder.DropTable(
                name: "Worktypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Modalities");

            migrationBuilder.DropTable(
                name: "Modalitytypes");

            migrationBuilder.DropTable(
                name: "Ordetypes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Paytypes");

            migrationBuilder.DropTable(
                name: "Proceduretypes");

            migrationBuilder.DropTable(
                name: "Reasons");
        }
    }
}
