using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ris2022.Data.Migrations
{
    public partial class ReasonToPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "024ed066-22ce-4280-901f-7f6120b1138f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4e7097e3-550c-4396-b684-e7d8609e0d8c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a63ed26a-e35b-43a5-947b-1a9546b2e03b");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Departmentid", "Email", "EmailConfirmed", "Firstname", "Isdoctor", "Languageid", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2326a1f2-a58a-4f03-92ab-1aea67ed6a28", 0, "1f8ffe5a-de0c-49be-8112-241d90d0107c", null, "RISAdmin@yy.com", true, "RIS", true, 1, "Admin", false, null, null, null, "P@ssw0rd123", null, true, "4dcbce47-0eb7-441f-8ad6-ddf8c5515988", false, "RISAdmin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48c53fbb-fd41-4d65-9e44-66e4079f18bc", "ac17d7ac-dbce-40fe-999a-8a232767654e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d01ce298-d77e-4b5a-b13e-09e6dc378e87", "c0dc3c2e-e286-4c89-a9b1-ebbef755fde4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Reasonid",
                table: "Patients",
                column: "Reasonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Reasons_Reasonid",
                table: "Patients",
                column: "Reasonid",
                principalTable: "Reasons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Reasons_Reasonid",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Reasonid",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "2326a1f2-a58a-4f03-92ab-1aea67ed6a28");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "48c53fbb-fd41-4d65-9e44-66e4079f18bc");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d01ce298-d77e-4b5a-b13e-09e6dc378e87");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Departmentid", "Email", "EmailConfirmed", "Firstname", "Isdoctor", "Languageid", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "024ed066-22ce-4280-901f-7f6120b1138f", 0, "c543e544-958e-492d-9d95-f410a78f1ab5", null, "RISAdmin@yy.com", true, "RIS", true, 1, "Admin", false, null, null, null, "P@ssw0rd123", null, true, "2bf0e1b1-0148-448b-9de2-5d4c65dded27", false, "RISAdmin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e7097e3-550c-4396-b684-e7d8609e0d8c", "ce7a8304-d3bd-4090-8923-c6cf14b3ab94", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a63ed26a-e35b-43a5-947b-1a9546b2e03b", "58aa212c-7c46-4057-b26b-c805362721b8", "Administrator", "ADMINISTRATOR" });
        }
    }
}
