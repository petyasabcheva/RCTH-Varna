using Microsoft.EntityFrameworkCore.Migrations;

namespace RCTH.Migrations
{
    public partial class MedResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_MedResults_MedResultId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_MedResultId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "MedResultId",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "MedResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MedResults_DonationId",
                table: "MedResults",
                column: "DonationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedResults_Donations_DonationId",
                table: "MedResults",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedResults_Donations_DonationId",
                table: "MedResults");

            migrationBuilder.DropIndex(
                name: "IX_MedResults_DonationId",
                table: "MedResults");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "MedResults");

            migrationBuilder.AddColumn<int>(
                name: "MedResultId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_MedResultId",
                table: "Donations",
                column: "MedResultId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_MedResults_MedResultId",
                table: "Donations",
                column: "MedResultId",
                principalTable: "MedResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
