using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_Books_Genres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genre",
                value: "Romance");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genre",
                value: "Science Fiction");

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 3, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1912), new DateTime(2024, 11, 11, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 8, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 11, 12, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 14, 9, 6, 46, 855, DateTimeKind.Utc).AddTicks(1942), new DateTime(2024, 11, 12, 9, 6, 46, 855, DateTimeKind.Utc).AddTicks(1942) });
        }
    }
}
