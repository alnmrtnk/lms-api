using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_Users_InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 28, 58, 682, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 11, 24, 16, 28, 58, 682, DateTimeKind.Utc).AddTicks(9020), 3 });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 28, 58, 682, DateTimeKind.Utc).AddTicks(9024), 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 28, 58, 682, DateTimeKind.Utc).AddTicks(9042), new DateTime(2024, 11, 25, 16, 28, 58, 682, DateTimeKind.Utc).AddTicks(9041), 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 27, 10, 28, 58, 682, DateTimeKind.Utc).AddTicks(9044), new DateTime(2024, 11, 25, 10, 28, 58, 682, DateTimeKind.Utc).AddTicks(9043), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Role",
                value: "Reader");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Role",
                value: "Reader");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Role",
                value: "Librarian");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Role",
                value: "Librarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 17, 38, 158, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 11, 24, 16, 17, 38, 158, DateTimeKind.Utc).AddTicks(4518), 10 });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 17, 38, 158, DateTimeKind.Utc).AddTicks(4522), 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 17, 38, 158, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 11, 25, 16, 17, 38, 158, DateTimeKind.Utc).AddTicks(4535), 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[] { new DateTime(2024, 11, 27, 10, 17, 38, 158, DateTimeKind.Utc).AddTicks(4537), new DateTime(2024, 11, 25, 10, 17, 38, 158, DateTimeKind.Utc).AddTicks(4537), 7 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Role",
                value: "Librarian");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Role",
                value: "Librarian");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Role",
                value: "Reader");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Role",
                value: "Reader");
        }
    }
}
