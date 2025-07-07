using Api.Models;

namespace Api.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        EmployeeDetails? GetEmployeeDetails(string id);
        bool UpdateSalary(string id, decimal newSalary);
    }
}
