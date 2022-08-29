using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ris2022.Data.Migrations
{
    public partial class ConfigureEntitiesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Risusers");

            migrationBuilder.DropTable(
                name: "Userroles");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90f7b606-c423-4587-aa16-946b53df6804");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9157a227-f359-44fb-9caf-41fc26b69209");

            migrationBuilder.InsertData(
                table: "Acceptancetypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });

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
                    { "8af6efc3-9429-4f7c-ad40-1b4ee01a6f97", "ec4f3466-faf7-402c-afb5-87b62a0a6fa3", "User", "USER" },
                    { "b5d9b55b-47df-419f-8f2f-d075825acfa2", "b0f569cf-fbae-4f19-856f-bf55aaae75a7", "Administrator", "ADMINISTATOR" }
                });

            migrationBuilder.InsertData(
                table: "Worktypes",
                columns: new[] { "Id", "Namear", "Nameen" },
                values: new object[] { 1, "اختبار", "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acceptancetypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Martialstatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modalities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modalitytypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ordetypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paytypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proceduretypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8af6efc3-9429-4f7c-ad40-1b4ee01a6f97");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b5d9b55b-47df-419f-8f2f-d075825acfa2");

            migrationBuilder.DeleteData(
                table: "Worktypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Risusers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Departmentid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Firstname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Isdoctor = table.Column<bool>(type: "NUMBER(1)", nullable: true),
                    Languageid = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Lastname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Pass = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Username = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Userroleid = table.Column<int>(type: "NUMBER(10)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90f7b606-c423-4587-aa16-946b53df6804", "81298170-3641-4e0e-b17e-dd26c37a356c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9157a227-f359-44fb-9caf-41fc26b69209", "325c6884-4b49-40a4-b631-901c15a6cdc3", "Administrator", "ADMINISTATOR" });
        }
    }
}
