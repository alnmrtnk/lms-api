using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Change_Password_Hashing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 9, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 11, 17, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 14, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4866), new DateTime(2024, 11, 18, 13, 50, 30, 113, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 7, 50, 30, 113, DateTimeKind.Utc).AddTicks(4869), new DateTime(2024, 11, 18, 7, 50, 30, 113, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "PrP+ZrMeO00Q+nC1ytSccRIpSvauTkdqHEBRVdRaoSE=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "74mVnB0WDowisJu3rvXBOX6l6ao0sS1QV2JDb8MYrVE=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "YoKgFiHFuNGeK6R4gJsjrJc/G0gmVq2bs1qMaukDMHA=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "7SMDScymeN3URXYx4m2NRKROWZGRxhmjUrXvfR+MakY=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 9, 9, 59, 0, 781, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 11, 17, 9, 59, 0, 781, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 14, 9, 59, 0, 781, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 59, 0, 781, DateTimeKind.Utc).AddTicks(453), new DateTime(2024, 11, 18, 9, 59, 0, 781, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 20, 3, 59, 0, 781, DateTimeKind.Utc).AddTicks(455), new DateTime(2024, 11, 18, 3, 59, 0, 781, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "3eb3fe66b31e3b4d10fa70b5cad49c7112294af6ae4e476a1c405155d45aa121");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "ef89959c1d160e8c22b09bb7aef5c1397ea5e9aa34b12d505762436fc318ad51");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "6282a01621c5b8d19e2ba478809b23ac973f1b482656ad9bb35a8c6ae9033070");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "ed230349cca678ddd4457631e26d8d44a44e599191c619a352b5ef7d1f8c6a46");
        }
    }
}
