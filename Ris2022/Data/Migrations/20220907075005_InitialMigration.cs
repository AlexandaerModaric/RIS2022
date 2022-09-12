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
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Languageid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Firstname = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
                    Lastname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Departmentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Isdoctor = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
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
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
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
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Gendre = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Mothername = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Age = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Mobilephone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Landphone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Currentaddress = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Residentaddress = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Workphone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Workaddress = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nearestperson = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nearestpersonphone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Birthplace = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Notes = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Translatedfname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Translatedlname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Translatedfathername = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Translatedmothername = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Insertdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    UpdateuserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Updatedate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Reasonid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    InsertUserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nationalityid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Worktypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Martialstatusid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Acceptancetypeid = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Acceptancetypes_A~",
                        column: x => x.Acceptancetypeid,
                        principalTable: "Acceptancetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Martialstatuses_M~",
                        column: x => x.Martialstatusid,
                        principalTable: "Martialstatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patients_Nationalities_Nat~",
                        column: x => x.Nationalityid,
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patients_Worktypes_Worktyp~",
                        column: x => x.Worktypeid,
                        principalTable: "Worktypes",
                        principalColumn: "Id");
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
                    Doctorid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RisAppDoctorId = table.Column<string>(type: "NVARCHAR2(450)", nullable: true),
                    Autoexpiredate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Accessionnumber = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Departmentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Documentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Ordertypeid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Insertdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    InsertuserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Reasonid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UpdateuserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
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
                        name: "FK_orders_AppUser_RisAppDocto~",
                        column: x => x.RisAppDoctorId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Clinics_Clinicid",
                        column: x => x.Clinicid,
                        principalTable: "Clinics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_Departments_Departm~",
                        column: x => x.Departmentid,
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

            migrationBuilder.InsertData(
                table: "Acceptancetypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Departmentid", "Email", "EmailConfirmed", "Firstname", "Isdoctor", "Languageid", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "024ed066-22ce-4280-901f-7f6120b1138f", 0, "c543e544-958e-492d-9d95-f410a78f1ab5", null, "RISAdmin@yy.com", true, "RIS", true, 1, "Admin", false, null, null, null, "P@ssw0rd123", null, true, "2bf0e1b1-0148-448b-9de2-5d4c65dded27", false, "RISAdmin" });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Cost", "Namear", "Nameen" },
                values: new object[] { 1, null, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "Namear", "Nameen" },
                values: new object[] { 1, "te", "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Martialstatuses",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Modalities",
                columns: new[] { "Id", "Aetitle", "Departmentid", "Description", "Ipaddress", "Modalitytypeid", "Name", "Port" },
                values: new object[] { 1, "test", 1, "test", "127.0.0.1", 1, "test", 104 });

            migrationBuilder.InsertData(
                table: "Modalitytypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Ordetypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Paytypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Proceduretypes",
                columns: new[] { "Id", "Namear", "Nameen", "Parentnum" },
                values: new object[] { 1, "اختبار", "test", 0 });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e7097e3-550c-4396-b684-e7d8609e0d8c", "ce7a8304-d3bd-4090-8923-c6cf14b3ab94", "User", "USER" },
                    { "a63ed26a-e35b-43a5-947b-1a9546b2e03b", "58aa212c-7c46-4057-b26b-c805362721b8", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Worktypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "\"NormalizedUserName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Clinicid",
                table: "orders",
                column: "Clinicid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Departmentid",
                table: "orders",
                column: "Departmentid");

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

            migrationBuilder.CreateIndex(
                name: "IX_orders_RisAppDoctorId",
                table: "orders",
                column: "RisAppDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Acceptancetypeid",
                table: "Patients",
                column: "Acceptancetypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Martialstatusid",
                table: "Patients",
                column: "Martialstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Nationalityid",
                table: "Patients",
                column: "Nationalityid");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Worktypeid",
                table: "Patients",
                column: "Worktypeid");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "\"NormalizedName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Clinics");

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

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Acceptancetypes");

            migrationBuilder.DropTable(
                name: "Martialstatuses");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Worktypes");
        }
    }
}
