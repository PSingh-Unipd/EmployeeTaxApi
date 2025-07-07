using Api.Models;

namespace Api.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee? GetById(string id);
        void Update(Employee employee);
    }
}
