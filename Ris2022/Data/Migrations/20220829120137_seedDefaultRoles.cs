using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ris2022.Data.Migrations
{
    public partial class seedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90f7b606-c423-4587-aa16-946b53df6804", "81298170-3641-4e0e-b17e-dd26c37a356c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9157a227-f359-44fb-9caf-41fc26b69209", "325c6884-4b49-40a4-b631-901c15a6cdc3", "Administrator", "ADMINISTATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90f7b606-c423-4587-aa16-946b53df6804");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9157a227-f359-44fb-9caf-41fc26b69209");
        }
    }
}
