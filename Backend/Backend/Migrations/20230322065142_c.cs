using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea071495-cb14-4006-992b-94a5952a8daa", "AQAAAAEAACcQAAAAEG48IExr/QufcL6MkUmuVSiE37sB5gOQxKWK63dSfZVthMtzRI/5PSUyxHeRQHJuAQ==", "311535ec-b1de-4732-9fb2-7021d91d86e8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "056f40f2-5fc9-41fb-8036-f1670e7344a3",
                columns: new[] { "DOB", "DOJ" },
                values: new object[] { new DateTime(2023, 3, 22, 12, 21, 42, 545, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 3, 22, 12, 21, 42, 545, DateTimeKind.Local).AddTicks(9699) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
