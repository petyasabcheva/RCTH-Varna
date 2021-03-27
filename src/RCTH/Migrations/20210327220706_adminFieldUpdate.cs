using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RCTH.Migrations
{
    public partial class adminFieldUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { new DateTime(2021, 3, 28, 0, 7, 5, 477, DateTimeKind.Local).AddTicks(7326), "60c69ab4-8560-44d3-a585-dd3e65b7d815", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPDyBX/pdoeOBB2xqsQtffv3i3N0T21UL/sgglZYoAJBH5O+gIzfqA6vLlGcaoQSsQ==", "726ca0c9-9a34-4ddd-9868-18de863e29d1", "admin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "01f8bf61-91f0-4a18-9b82-70c5e2c5e304");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { new DateTime(2021, 3, 28, 0, 3, 24, 981, DateTimeKind.Local).AddTicks(2279), "649a9b5a-d60d-468a-8c6e-ccfd76bee68f", "ADMIN", "AQAAAAEAACcQAAAAECjs8EsE8bOvlniDlsogCdduk2WrFxfj7C8USqkWRkIog+jn7h3KdUz9ldtC9vX5Wg==", "95f70674-7f77-414c-843a-1edc9c070c03", "Admin" });
        }
    }
}
