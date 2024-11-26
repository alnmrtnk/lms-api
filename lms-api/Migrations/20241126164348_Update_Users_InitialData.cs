using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 43, 48, 212, DateTimeKind.Utc).AddTicks(4872), new DateTime(2024, 11, 24, 16, 43, 48, 212, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 21, 16, 43, 48, 212, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 43, 48, 212, DateTimeKind.Utc).AddTicks(4903), new DateTime(2024, 11, 25, 16, 43, 48, 212, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 27, 10, 43, 48, 212, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 11, 25, 10, 43, 48, 212, DateTimeKind.Utc).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "grace@library.com", "Y8kK+TLlticw4AaaA/Ax+MeUIEQoe6TiHRNuRcLvs7w=", "Grace Monte" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { "sam@library.com", "5BtKnn4OCnquIpBLJNhGNVkoQ0dDlvqcYM1y0A+XUrg=", "Admin", "Sam Roy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "lily@library.com", "V2axAikuFtbExIeEwO3G0JyJHthuJ+pMY+8+kvjg2mA=", "Lily Carter" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "jack@library.com", "bKSgGhL0KvthM8mf6fi6dgwcSsob+NDdw4glaZEZ3Ac=", "Jack Stone" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 5, "emily@library.com", "T1yQzWe9y0R0JuYVgZTampp2qwAMLVqfoZZ8yl8cs9M=", "Librarian", "Emily Frost" },
                    { 6, "noah@library.com", "05M5ULAjo56/bh0RFESsgt73DVyujBIhpWenS/8zZCk=", "Librarian", "Noah Blake" },
                    { 7, "mia@library.com", "eKGaRTHg05mtAJ/rnHcaf9F5Gb2qs8vZ7SaFUdo+KDY=", "Librarian", "Mia Grant" },
                    { 8, "luke@library.com", "GEwOKlK9l1aRFYF8nzxQqcbdBIs3Gdr3xqYZRDghrkA=", "Librarian", "Luke Harris" },
                    { 9, "ava@library.com", "rnQ8+oqmRK5bFuEDzVD1Ga4aB+H05uwJcxuevZcAnZw=", "Reader", "Ava Reed" },
                    { 10, "ethan@library.com", "MGWX1IZvcgbHG7Nh9aMoBSEfY7W1IVVw2d295qCLCMk=", "Reader", "Ethan Cole" },
                    { 11, "chloe@library.com", "X5/m6Zc7roSoGNmqeBNbGPp33tPhYaB2WOYjOoCh+bk=", "Reader", "Chloe James" },
                    { 12, "leo@library.com", "OvvXHhHDdDBkm2C+L8O3D5wl/pg0A/ABNKa2UGvkhFc=", "Reader", "Leo Bennett" },
                    { 13, "sophia@library.com", "eCGqh+LOEERyE+pHFIleoZHn/WYyEjjQeSFt5e5c8JI=", "Reader", "Sophia Lane" },
                    { 14, "max@library.com", "UhM5MwmSdx/1gRR9hvm1RUL2atus5kJU+rZ+AFnEQHU=", "Reader", "Max Hill" },
                    { 15, "ella@library.com", "nDVzp00nGKcR2SnJV6ezoutF3VV+Diqx5wWj9b7i820=", "Reader", "Ella Moore" },
                    { 16, "liam@library.com", "rPyKFwR9R8MIc5wv45jX5QEtjQyrlwJI6IxAl9NDJMI=", "Reader", "Liam Cross" },
                    { 17, "zoe@library.com", "UkiwdzTofWIkhq6Dqdc40o9zvEKedJpMqgVnSSI6TEo=", "Reader", "Zoe Clark" },
                    { 18, "ruby@library.com", "Rn7NLtTSGeQe8DQW15Ab9f7h1CQlolSNt1WGoBQHpOQ=", "Reader", "Ruby Hayes" },
                    { 19, "oliver@library.com", "vzNdAjNU2SvUW2JNc/VtDj2jTq6ltNXoPAq6N2GNFgs=", "Reader", "Oliver Knight" },
                    { 20, "ivy@library.com", "Ey7xSjeGMHE9BnntKIdxkbIBO/JZAeeBHF+9lrU0xFQ=", "Reader", "Ivy Brooks" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(266), new DateTime(2024, 11, 23, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 11, 20, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 11, 24, 19, 3, 58, 58, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 3, 58, 58, DateTimeKind.Utc).AddTicks(343), new DateTime(2024, 11, 24, 13, 3, 58, 58, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "admin@library.com", "PrP+ZrMeO00Q+nC1ytSccRIpSvauTkdqHEBRVdRaoSE=", "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { "librarian@library.com", "74mVnB0WDowisJu3rvXBOX6l6ao0sS1QV2JDb8MYrVE=", "Librarian", "librarian" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "reader1@library.com", "YoKgFiHFuNGeK6R4gJsjrJc/G0gmVq2bs1qMaukDMHA=", "reader1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "PasswordHash", "Username" },
                values: new object[] { "reader2@library.com", "7SMDScymeN3URXYx4m2NRKROWZGRxhmjUrXvfR+MakY=", "reader2" });
        }
    }
}
