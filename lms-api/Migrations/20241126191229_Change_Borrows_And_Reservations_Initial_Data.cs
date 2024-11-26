using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Change_Borrows_And_Reservations_Initial_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrows_Users_UserId",
                table: "Borrows");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Borrows",
                newName: "ReaderId");

            migrationBuilder.RenameIndex(
                name: "IX_Borrows_UserId",
                table: "Borrows",
                newName: "IX_Borrows_ReaderId");

            migrationBuilder.AddColumn<int>(
                name: "LibrarianId",
                table: "Borrows",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "LibrarianId", "ReturnDate" },
                values: new object[] { new DateTime(2024, 11, 16, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8755), 5, new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "LibrarianId" },
                values: new object[] { new DateTime(2024, 11, 21, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8768), 6 });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "LibrarianId", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { 3, 5, new DateTime(2024, 11, 18, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8769), 7, 9, new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8770) },
                    { 4, 6, new DateTime(2024, 11, 14, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8771), 8, 10, new DateTime(2024, 11, 23, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8772) },
                    { 5, 7, new DateTime(2024, 11, 11, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8773), 5, 11, new DateTime(2024, 11, 21, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8774) },
                    { 6, 8, new DateTime(2024, 11, 19, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8775), 6, 12, new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8776) },
                    { 7, 9, new DateTime(2024, 11, 20, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8777), 7, 13, null },
                    { 8, 10, new DateTime(2024, 11, 6, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8779), 8, 14, new DateTime(2024, 11, 16, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8779) },
                    { 9, 11, new DateTime(2024, 11, 12, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8781), 5, 15, new DateTime(2024, 11, 22, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8781) },
                    { 10, 12, new DateTime(2024, 11, 8, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8783), 6, 16, new DateTime(2024, 11, 18, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8783) },
                    { 11, 13, new DateTime(2024, 11, 1, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8785), 7, 17, new DateTime(2024, 11, 11, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8785) },
                    { 12, 14, new DateTime(2024, 11, 4, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8787), 8, 18, new DateTime(2024, 11, 14, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8787) },
                    { 13, 15, new DateTime(2024, 10, 27, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8789), 5, 19, new DateTime(2024, 11, 6, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8789) },
                    { 14, 16, new DateTime(2024, 11, 21, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8791), 6, 9, null },
                    { 15, 17, new DateTime(2024, 11, 17, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8792), 7, 3, new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8792) },
                    { 16, 18, new DateTime(2024, 11, 15, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8794), 8, 10, new DateTime(2024, 11, 23, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8794) },
                    { 17, 19, new DateTime(2024, 11, 13, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8796), 5, 4, new DateTime(2024, 11, 22, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8796) },
                    { 18, 20, new DateTime(2024, 11, 16, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8798), 6, 11, new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8798) },
                    { 19, 21, new DateTime(2024, 11, 11, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8800), 7, 12, new DateTime(2024, 11, 21, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8800) },
                    { 20, 22, new DateTime(2024, 11, 23, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8801), 8, 13, null }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 27, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "ReservationDate" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 12, 29, 202, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 11, 25, 13, 12, 29, 202, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BookId", "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 3, 8, new DateTime(2024, 11, 27, 7, 12, 29, 202, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 11, 25, 7, 12, 29, 202, DateTimeKind.Utc).AddTicks(8831), 10 },
                    { 4, 9, new DateTime(2024, 11, 27, 3, 12, 29, 202, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 11, 25, 3, 12, 29, 202, DateTimeKind.Utc).AddTicks(8833), 12 },
                    { 5, 10, new DateTime(2024, 11, 27, 17, 12, 29, 202, DateTimeKind.Utc).AddTicks(8835), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8835), 13 },
                    { 6, 11, new DateTime(2024, 11, 26, 21, 12, 29, 202, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 11, 24, 21, 12, 29, 202, DateTimeKind.Utc).AddTicks(8836), 14 },
                    { 7, 12, new DateTime(2024, 11, 26, 15, 12, 29, 202, DateTimeKind.Utc).AddTicks(8839), new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8838), 15 },
                    { 8, 13, new DateTime(2024, 11, 27, 3, 12, 29, 202, DateTimeKind.Utc).AddTicks(8841), new DateTime(2024, 11, 25, 5, 12, 29, 202, DateTimeKind.Utc).AddTicks(8840), 16 },
                    { 9, 14, new DateTime(2024, 11, 27, 18, 12, 29, 202, DateTimeKind.Utc).AddTicks(8842), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8842), 17 },
                    { 10, 15, new DateTime(2024, 11, 26, 13, 12, 29, 202, DateTimeKind.Utc).AddTicks(8844), new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8844), 18 },
                    { 11, 16, new DateTime(2024, 11, 27, 15, 12, 29, 202, DateTimeKind.Utc).AddTicks(8846), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8845), 19 },
                    { 12, 17, new DateTime(2024, 11, 27, 1, 12, 29, 202, DateTimeKind.Utc).AddTicks(8847), new DateTime(2024, 11, 25, 1, 12, 29, 202, DateTimeKind.Utc).AddTicks(8847), 9 },
                    { 13, 18, new DateTime(2024, 11, 26, 23, 12, 29, 202, DateTimeKind.Utc).AddTicks(8849), new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8849), 3 },
                    { 14, 19, new DateTime(2024, 11, 26, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8851), new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8851), 4 },
                    { 15, 20, new DateTime(2024, 11, 27, 8, 12, 29, 202, DateTimeKind.Utc).AddTicks(8853), new DateTime(2024, 11, 25, 8, 12, 29, 202, DateTimeKind.Utc).AddTicks(8852), 10 },
                    { 16, 21, new DateTime(2024, 11, 27, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8855), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8854), 11 },
                    { 17, 22, new DateTime(2024, 11, 27, 13, 12, 29, 202, DateTimeKind.Utc).AddTicks(8856), new DateTime(2024, 11, 25, 13, 12, 29, 202, DateTimeKind.Utc).AddTicks(8856), 12 },
                    { 18, 23, new DateTime(2024, 11, 27, 11, 12, 29, 202, DateTimeKind.Utc).AddTicks(8858), new DateTime(2024, 11, 25, 11, 12, 29, 202, DateTimeKind.Utc).AddTicks(8858), 13 },
                    { 19, 24, new DateTime(2024, 11, 27, 3, 12, 29, 202, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 11, 25, 3, 12, 29, 202, DateTimeKind.Utc).AddTicks(8860), 14 },
                    { 20, 25, new DateTime(2024, 11, 27, 18, 12, 29, 202, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8861), 15 },
                    { 21, 1, new DateTime(2024, 11, 27, 16, 12, 29, 202, DateTimeKind.Utc).AddTicks(8864), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8863), 16 },
                    { 22, 3, new DateTime(2024, 11, 26, 20, 12, 29, 202, DateTimeKind.Utc).AddTicks(8865), new DateTime(2024, 11, 24, 20, 12, 29, 202, DateTimeKind.Utc).AddTicks(8865), 17 },
                    { 23, 5, new DateTime(2024, 11, 27, 4, 12, 29, 202, DateTimeKind.Utc).AddTicks(8867), new DateTime(2024, 11, 25, 4, 12, 29, 202, DateTimeKind.Utc).AddTicks(8866), 18 },
                    { 24, 7, new DateTime(2024, 11, 27, 17, 12, 29, 202, DateTimeKind.Utc).AddTicks(8869), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8868), 19 },
                    { 25, 9, new DateTime(2024, 11, 27, 5, 12, 29, 202, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 11, 25, 5, 12, 29, 202, DateTimeKind.Utc).AddTicks(8870), 9 },
                    { 26, 11, new DateTime(2024, 11, 27, 18, 12, 29, 202, DateTimeKind.Utc).AddTicks(8872), new DateTime(2024, 11, 25, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8872), 3 },
                    { 27, 13, new DateTime(2024, 11, 26, 22, 12, 29, 202, DateTimeKind.Utc).AddTicks(8874), new DateTime(2024, 11, 24, 22, 12, 29, 202, DateTimeKind.Utc).AddTicks(8874), 4 },
                    { 28, 15, new DateTime(2024, 11, 27, 6, 12, 29, 202, DateTimeKind.Utc).AddTicks(8876), new DateTime(2024, 11, 25, 6, 12, 29, 202, DateTimeKind.Utc).AddTicks(8875), 10 },
                    { 29, 17, new DateTime(2024, 11, 26, 23, 12, 29, 202, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 11, 24, 19, 12, 29, 202, DateTimeKind.Utc).AddTicks(8877), 11 },
                    { 30, 19, new DateTime(2024, 11, 27, 0, 12, 29, 202, DateTimeKind.Utc).AddTicks(8879), new DateTime(2024, 11, 25, 0, 12, 29, 202, DateTimeKind.Utc).AddTicks(8879), 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_LibrarianId",
                table: "Borrows",
                column: "LibrarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrows_Users_LibrarianId",
                table: "Borrows",
                column: "LibrarianId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrows_Users_ReaderId",
                table: "Borrows",
                column: "ReaderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrows_Users_LibrarianId",
                table: "Borrows");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrows_Users_ReaderId",
                table: "Borrows");

            migrationBuilder.DropIndex(
                name: "IX_Borrows_LibrarianId",
                table: "Borrows");

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "LibrarianId",
                table: "Borrows");

            migrationBuilder.RenameColumn(
                name: "ReaderId",
                table: "Borrows",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Borrows_ReaderId",
                table: "Borrows",
                newName: "IX_Borrows_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Borrows_Users_UserId",
                table: "Borrows",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
