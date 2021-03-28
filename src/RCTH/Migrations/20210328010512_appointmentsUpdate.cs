using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RCTH.Migrations
{
    public partial class appointmentsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAndTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "fa5ff4f5-387d-4529-8034-0eba838de14b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 3, 28, 4, 5, 11, 266, DateTimeKind.Local).AddTicks(1663), "9437d356-17e6-4c46-a0be-4aa6f3510278", "AQAAAAEAACcQAAAAEHc1XhlRBAud5bkycT5/kImwDuD/pOfQ4HSETHtpjaX5/Ol1XQTaAYvGGllzyzkjAQ==", "b3ea0a0b-a699-4ade-aa8f-537ef27c24c8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAndTime",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4d67c8b7-ee9a-4b87-b709-6be5e1135076");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 3, 28, 0, 7, 5, 477, DateTimeKind.Local).AddTicks(7326), "60c69ab4-8560-44d3-a585-dd3e65b7d815", "AQAAAAEAACcQAAAAEPDyBX/pdoeOBB2xqsQtffv3i3N0T21UL/sgglZYoAJBH5O+gIzfqA6vLlGcaoQSsQ==", "726ca0c9-9a34-4ddd-9868-18de863e29d1" });
        }
    }
}
