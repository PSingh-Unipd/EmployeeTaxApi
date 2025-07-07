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
                    GrossAnnualSalary = table.Column<decimal>(
                        type: "decimal(18,2)",
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                }
            );

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "GrossAnnualSalary", "LastName" },
                values: new object[,]
                {
                    { "1", "Alice", 50000m, "Johnson" },
                    { "10", "Julia", 63000m, "Gray" },
                    { "11", "Kevin", 47000m, "Brown" },
                    { "12", "Laura", 67000m, "Wright" },
                    { "13", "Michael", 53000m, "King" },
                    { "14", "Nina", 49000m, "Young" },
                    { "15", "Oscar", 58000m, "Hall" },
                    { "16", "Paula", 76000m, "Scott" },
                    { "17", "Quentin", 62000m, "Moore" },
                    { "18", "Rachel", 54000m, "Clark" },
                    { "19", "Steven", 47000m, "Lewis" },
                    { "2", "Bob", 60000m, "Smith" },
                    { "20", "Tina", 61000m, "Walker" },
                    { "3", "Charlie", 45000m, "Brown" },
                    { "4", "Diana", 70000m, "Reed" },
                    { "5", "Ethan", 55000m, "Cole" },
                    { "6", "Fiona", 80000m, "Black" },
                    { "7", "George", 48000m, "White" },
                    { "8", "Hannah", 75000m, "Green" },
                    { "9", "Ian", 52000m, "Blue" },
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Employees");
        }
    }
}
