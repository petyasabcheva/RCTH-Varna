using Microsoft.EntityFrameworkCore.Migrations;

namespace RCTH.Migrations
{
    public partial class medresultProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "MedResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HIV",
                table: "MedResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HepatitisB",
                table: "MedResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HepatitisC",
                table: "MedResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PCR",
                table: "MedResults",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Syphilis",
                table: "MedResults",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "HIV",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "HepatitisB",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "HepatitisC",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "PCR",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "Syphilis",
                table: "MedResults");
        }
    }
}
