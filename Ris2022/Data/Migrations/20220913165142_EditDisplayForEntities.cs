using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ris2022.Data.Migrations
{
    public partial class EditDisplayForEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Worktypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Worktypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Reasons",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Reasons",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Proceduretypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Proceduretypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Paytypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Paytypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Port",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modalities",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Modalitytypeid",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ipaddress",
                table: "Modalities",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Modalities",
                type: "NVARCHAR2(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aetitle",
                table: "Modalities",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Martialstatuses",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Martialstatuses",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Languages",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Languages",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Departments",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Departments",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Clinics",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Clinics",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Acceptancetypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Acceptancetypes",
                type: "NVARCHAR2(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Departmentid", "Email", "EmailConfirmed", "Firstname", "Isdoctor", "Languageid", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24475690-53f7-4256-9a50-6ad0ec3037f0", 0, "838d9fa4-669c-4034-9319-ced3dba32fc0", null, "RISAdmin@yy.com", true, "RIS", true, 1, "Admin", false, null, null, null, "P@ssw0rd123", null, true, "2a871722-6c78-467e-854d-f9ae5332918d", false, "RISAdmin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ac10e94-146a-4e09-97ca-85304f0a3ce5", "76934d31-dc62-4c42-9a61-fe22136aebab", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e39df797-84c8-4e72-88ff-dbc7e5bae028", "e6a207a4-fccf-4cea-914e-a609cc2c4142", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Modalities_Departmentid",
                table: "Modalities",
                column: "Departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Modalities_Modalitytypeid",
                table: "Modalities",
                column: "Modalitytypeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Modalities_Departments_Dep~",
                table: "Modalities",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modalities_Modalitytypes_M~",
                table: "Modalities",
                column: "Modalitytypeid",
                principalTable: "Modalitytypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modalities_Departments_Dep~",
                table: "Modalities");

            migrationBuilder.DropForeignKey(
                name: "FK_Modalities_Modalitytypes_M~",
                table: "Modalities");

            migrationBuilder.DropIndex(
                name: "IX_Modalities_Departmentid",
                table: "Modalities");

            migrationBuilder.DropIndex(
                name: "IX_Modalities_Modalitytypeid",
                table: "Modalities");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "24475690-53f7-4256-9a50-6ad0ec3037f0");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1ac10e94-146a-4e09-97ca-85304f0a3ce5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e39df797-84c8-4e72-88ff-dbc7e5bae028");

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Worktypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Worktypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Reasons",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Reasons",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Proceduretypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Proceduretypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Paytypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Paytypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "Port",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modalities",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "Modalitytypeid",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Ipaddress",
                table: "Modalities",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Modalities",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Modalities",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Aetitle",
                table: "Modalities",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Martialstatuses",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Martialstatuses",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Languages",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Languages",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Departments",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Departments",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Clinics",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Clinics",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nameen",
                table: "Acceptancetypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Namear",
                table: "Acceptancetypes",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(25)",
                oldMaxLength: 25);

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
        }
    }
}
