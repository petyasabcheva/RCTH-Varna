using Microsoft.EntityFrameworkCore.Migrations;

namespace RCTH.Migrations
{
    public partial class BloodGroupSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RhFactor",
                table: "BloodGroups");

            migrationBuilder.InsertData(
                table: "BloodGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "B+" },
                    { 3, "AB+" },
                    { 4, "0+" },
                    { 5, "A-" },
                    { 6, "B-" },
                    { 7, "AB-" },
                    { 8, "0-" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AddColumn<bool>(
                name: "RhFactor",
                table: "BloodGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
