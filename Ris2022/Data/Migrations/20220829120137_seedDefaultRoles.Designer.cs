﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Ris2022.Data;

#nullable disable

namespace Ris2022.Data.Migrations
{
    [DbContext(typeof(RisDBContext))]
    [Migration("20220829120137_seedDefaultRoles")]
    partial class seedDefaultRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 30);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NormalizedName\" IS NOT NULL");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "90f7b606-c423-4587-aa16-946b53df6804",
                            ConcurrencyStamp = "81298170-3641-4e0e-b17e-dd26c37a356c",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "9157a227-f359-44fb-9caf-41fc26b69209",
                            ConcurrencyStamp = "325c6884-4b49-40a4-b631-901c15a6cdc3",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Ris2022.Data.Models.Acceptancetype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Acceptancetypes");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Cost")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Namear")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Namear")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Martialstatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Martialstatuses");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Modality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aetitle")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Departmentid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Ipaddress")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Modalitytypeid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Port")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Modalities");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Modalitytype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Modalitytypes");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Accessionnumber")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("Autoexpiredate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("Clinicid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Deptid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Doctorid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Documentid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("Insertdate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("Insertuserid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Modalityid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Modalitytypeid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Ordertypeid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Patientid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Payreasonid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Paytypeid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Proceduretypeid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Reasonid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("Statusid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Studyid")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("Updatedate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("Updateuserid")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("Deptid");

                    b.HasIndex("Modalityid");

                    b.HasIndex("Modalitytypeid");

                    b.HasIndex("Ordertypeid");

                    b.HasIndex("Patientid");

                    b.HasIndex("Paytypeid");

                    b.HasIndex("Proceduretypeid");

                    b.HasIndex("Reasonid");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Ordertype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Ordetypes");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.Property<int?>("Gendre")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Givenid")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.Property<string>("Middlename")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Paytype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Paytypes");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Proceduretype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Parentnum")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Proceduretypes");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Reason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Reasons");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Alergy")
                        .HasColumnType("RAW(2000)");

                    b.Property<int?>("Approved")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool?>("Approveddoctorid")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Audiopath")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("Imagedate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<byte[]>("Meidcalhistory")
                        .HasColumnType("RAW(2000)");

                    b.Property<byte[]>("Notes")
                        .HasColumnType("RAW(2000)");

                    b.Property<int>("Orderid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Parentreport")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Patientid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Physicianid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Raddoctorid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("Referingdoctorid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<byte[]>("Reportbody")
                        .HasColumnType("RAW(2000)");

                    b.Property<DateTime>("Reportdate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Seriesnumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<byte[]>("Title")
                        .HasColumnType("RAW(2000)");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Ris2022.Data.Models.RisAppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Departmentid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Firstname")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<bool?>("Isdoctor")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Lastname")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NormalizedUserName\" IS NOT NULL");

                    b.ToTable("AppUser", (string)null);
                });

            modelBuilder.Entity("Ris2022.Data.Models.Risuser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Departmentid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Firstname")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool?>("Isdoctor")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Lastname")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Userroleid")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Risusers");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Userrole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Userroles");
                });

            modelBuilder.Entity("Ris2022.Data.Models.Worktype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Namear")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nameen")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Worktypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ris2022.Data.Models.RisAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ris2022.Data.Models.RisAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ris2022.Data.Models.RisAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ris2022.Data.Models.RisAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ris2022.Data.Models.Order", b =>
                {
                    b.HasOne("Ris2022.Data.Models.Department", "dept")
                        .WithMany()
                        .HasForeignKey("Deptid");

                    b.HasOne("Ris2022.Data.Models.Modality", "modality")
                        .WithMany()
                        .HasForeignKey("Modalityid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ris2022.Data.Models.Modalitytype", "modalitytype")
                        .WithMany()
                        .HasForeignKey("Modalitytypeid");

                    b.HasOne("Ris2022.Data.Models.Ordertype", "Ordertype")
                        .WithMany()
                        .HasForeignKey("Ordertypeid");

                    b.HasOne("Ris2022.Data.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("Patientid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ris2022.Data.Models.Paytype", "paytype")
                        .WithMany()
                        .HasForeignKey("Paytypeid");

                    b.HasOne("Ris2022.Data.Models.Proceduretype", "proceduretype")
                        .WithMany()
                        .HasForeignKey("Proceduretypeid");

                    b.HasOne("Ris2022.Data.Models.Reason", "reason")
                        .WithMany()
                        .HasForeignKey("Reasonid");

                    b.Navigation("Ordertype");

                    b.Navigation("dept");

                    b.Navigation("modality");

                    b.Navigation("modalitytype");

                    b.Navigation("patient");

                    b.Navigation("paytype");

                    b.Navigation("proceduretype");

                    b.Navigation("reason");
                });
#pragma warning restore 612, 618
        }
    }
}
