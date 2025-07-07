using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.AsNoTracking().ToList();
        }

        public Employee? GetById(string id)
        {
            return _context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }
    }
}