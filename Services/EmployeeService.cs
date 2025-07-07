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
            if (employee == null)
                return null;

            var annualTaxPaid = CalculateUKIncomeTax(employee.GrossAnnualSalary);
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
                NetMonthlySalary = netAnnualSalary / 12,
            };
        }

        public bool UpdateSalary(string id, decimal newSalary)
        {
            var employee = _repository.GetById(id);
            if (employee == null)
                return false;

            employee.GrossAnnualSalary = newSalary;
            _repository.Update(employee);

            return true;
        }

        private decimal CalculateUKIncomeTax(decimal grossSalary)
        {
            decimal tax = 0m;

            if (grossSalary > 5000)
            {
                var bandBIncome = Math.Min(grossSalary, 20000m) - 5000m;
                tax += bandBIncome * 0.20m;
            }

            if (grossSalary > 20000)
            {
                var bandCIncome = grossSalary - 20000m;
                tax += bandCIncome * 0.40m;
            }

            return tax;
        }
    }
}
