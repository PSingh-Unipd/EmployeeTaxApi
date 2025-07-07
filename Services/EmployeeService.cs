using Api.Models;
using Api.Repositories;

namespace Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Employee> GetAllEmployees() => _repository.GetAll();

        public EmployeeDetails? GetEmployeeDetails(string id)
        {
            var employee = _repository.GetById(id);
            if (employee == null) return null;

            var taxRate = 0.25;
            var annualTaxPaid = employee.GrossAnnualSalary * taxRate;
            var netAnnualSalary = employee.GrossAnnualSalary - annualTaxPaid;

            return new EmployeeDetails
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                GrossAnnualSalary = employee.GrossAnnualSalary,
                GrossMonthlySalary = employee.GrossAnnualSalary / 12,
                AnnualTaxPaid = annualTaxPaid,
                MonthlyTaxPaid = annualTaxPaid / 12,
                NetAnnualSalary = netAnnualSalary,
                NetMonthlySalary = netAnnualSalary / 12
            };
        }
    }
}
