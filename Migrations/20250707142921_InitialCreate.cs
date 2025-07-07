using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossAnnualSalary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "GrossAnnualSalary", "LastName" },
                values: new object[,]
                {
                    { "1", "Alice", 50000.0, "Johnson" },
                    { "10", "Julia", 63000.0, "Gray" },
                    { "11", "Kevin", 47000.0, "Brown" },
                    { "12", "Laura", 67000.0, "Wright" },
                    { "13", "Michael", 53000.0, "King" },
                    { "14", "Nina", 49000.0, "Young" },
                    { "15", "Oscar", 58000.0, "Hall" },
                    { "16", "Paula", 76000.0, "Scott" },
                    { "17", "Quentin", 62000.0, "Moore" },
                    { "18", "Rachel", 54000.0, "Clark" },
                    { "19", "Steven", 47000.0, "Lewis" },
                    { "2", "Bob", 60000.0, "Smith" },
                    { "20", "Tina", 61000.0, "Walker" },
                    { "3", "Charlie", 45000.0, "Brown" },
                    { "4", "Diana", 70000.0, "Reed" },
                    { "5", "Ethan", 55000.0, "Cole" },
                    { "6", "Fiona", 80000.0, "Black" },
                    { "7", "George", 48000.0, "White" },
                    { "8", "Hannah", 75000.0, "Green" },
                    { "9", "Ian", 52000.0, "Blue" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
