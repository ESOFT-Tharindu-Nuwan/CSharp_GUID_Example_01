using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ebook.Migrations
{
    /// <inheritdoc />
    public partial class add_DeletedAt_column_to_books_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Books",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Books");
        }
    }
}
