using Api.Models;

namespace Api.Repositories
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private static readonly List<Employee> Employees = new()
        {
            new("1", "Alice", "Johnson", 50000),
            new("2", "Bob", "Smith", 60000),
            new("3", "Charlie", "Brown", 45000),
            new("4", "Diana", "Reed", 70000),
            new("5", "Ethan", "Cole", 55000),
            new("6", "Fiona", "Black", 80000),
            new("7", "George", "White", 48000),
            new("8", "Hannah", "Green", 75000),
            new("9", "Ian", "Blue", 52000),
            new("10", "Julia", "Gray", 63000),
            new("11", "Kevin", "Brown", 47000),
            new("12", "Laura", "Wright", 67000),
            new("13", "Michael", "King", 53000),
            new("14", "Nina", "Young", 49000),
            new("15", "Oscar", "Hall", 58000),
            new("16", "Paula", "Scott", 76000),
            new("17", "Quentin", "Moore", 62000),
            new("18", "Rachel", "Clark", 54000),
            new("19", "Steven", "Lewis", 47000),
            new("20", "Tina", "Walker", 61000),
        };

        public IEnumerable<Employee> GetAll() => Employees;

        public Employee? GetById(string id) => Employees.FirstOrDefault(e => e.Id == id);
    }
}
