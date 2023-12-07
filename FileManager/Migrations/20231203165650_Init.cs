using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileManager.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LatinString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RusString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IntegerNumber = table.Column<int>(type: "int", nullable: false),
                    FloatNumber = table.Column<decimal>(type: "decimal(30,20)", precision: 30, scale: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data");
        }
    }
}
