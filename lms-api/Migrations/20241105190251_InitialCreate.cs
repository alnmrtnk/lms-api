using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lms_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    CopiesAvailable = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CopiesAvailable", "ISBN", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", 5, "9780743273565", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Great Gatsby" },
                    { 2, "Harper Lee", 3, "9780061120084", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "To Kill a Mockingbird" },
                    { 3, "George Orwell", 4, "9780451524935", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc), "1984" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
