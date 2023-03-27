using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396ff05f-97f5-4a8d-aff5-ab6f860cdd30", "AQAAAAEAACcQAAAAECC2fU2/z5Id5Hgl9I+uT48ptmyThtMHsg1Z5bT/HPjqhr+Qe9XTT6USR6PWrXoPXQ==", "37d19a9c-e455-45c6-a8d9-c14f079eae35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "DOB", "DOJ" },
                values: new object[] { new DateTime(2023, 3, 22, 12, 7, 24, 162, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 3, 22, 12, 7, 24, 162, DateTimeKind.Local).AddTicks(2387) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5f9d22-6b44-44cf-a051-91f7b693dc43", "AQAAAAEAACcQAAAAEGEolK2skvS03rK2vXztQFN2h2fP24oSZwZnW223D3sl9DOK72ClEtxeIEWn66XIAw==", "dbe72652-93f7-4d24-be04-24f749b6ba12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "DOB", "DOJ" },
                values: new object[] { new DateTime(2023, 3, 22, 11, 56, 55, 701, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 3, 22, 11, 56, 55, 701, DateTimeKind.Local).AddTicks(8132) });
        }
    }
}
