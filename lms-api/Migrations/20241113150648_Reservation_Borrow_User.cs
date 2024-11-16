using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class Reservation_Borrow_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genre",
                value: "Fiction");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genre",
                value: "Fiction");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genre",
                value: "Science Fiction");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CopiesAvailable", "Genre", "ISBN", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 4, "J.R.R. Tolkien", 6, "Fantasy", "9780547928227", new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Hobbit" },
                    { 5, "Dan Brown", 2, "Mystery", "9780307474278", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "admin@library.com", "3eb3fe66b31e3b4d10fa70b5cad49c7112294af6ae4e476a1c405155d45aa121", "Admin", "admin" },
                    { 2, "librarian@library.com", "ef89959c1d160e8c22b09bb7aef5c1397ea5e9aa34b12d505762436fc318ad51", "Librarian", "librarian" },
                    { 3, "reader1@library.com", "6282a01621c5b8d19e2ba478809b23ac973f1b482656ad9bb35a8c6ae9033070", "Reader", "reader1" },
                    { 4, "reader2@library.com", "ed230349cca678ddd4457631e26d8d44a44e599191c619a352b5ef7d1f8c6a46", "Reader", "reader2" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 3, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1912), new DateTime(2024, 11, 11, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1921), 3 },
                    { 2, 3, new DateTime(2024, 11, 8, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1925), null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BookId", "ExpirationDate", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 11, 14, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 11, 12, 15, 6, 46, 855, DateTimeKind.Utc).AddTicks(1940), 3 },
                    { 2, 4, new DateTime(2024, 11, 14, 9, 6, 46, 855, DateTimeKind.Utc).AddTicks(1942), new DateTime(2024, 11, 12, 9, 6, 46, 855, DateTimeKind.Utc).AddTicks(1942), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_BookId",
                table: "Borrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_UserId",
                table: "Borrows",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Books");
        }
    }
}
