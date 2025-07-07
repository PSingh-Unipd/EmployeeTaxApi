using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
  [ApiController]
  [Route("api/employees")]
  public class EmployeeController : ControllerBase
  {
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
      _logger = logger;
    }

    private static readonly List<Employee> Employees = new()
    {
      new Employee("1", "Alice", "Johnson", 50000),
      new Employee("2", "Bob", "Smith", 60000),
      new Employee("3", "Charlie", "Brown", 45000),
      new Employee("4", "Diana", "Reed", 70000),
      new Employee("5", "Ethan", "Cole", 55000),
      new Employee("6", "Fiona", "Black", 80000),
      new Employee("7", "George", "White", 48000),
      new Employee("8", "Hannah", "Green", 75000),
      new Employee("9", "Ian", "Blue", 52000),
      new Employee("10", "Julia", "Gray", 63000),
      new Employee("11", "Kevin", "Brown", 47000),
      new Employee("12", "Laura", "Wright", 67000),
      new Employee("13", "Michael", "King", 53000),
      new Employee("14", "Nina", "Young", 49000),
      new Employee("15", "Oscar", "Hall", 58000),
      new Employee("16", "Paula", "Scott", 76000),
      new Employee("17", "Quentin", "Moore", 62000),
      new Employee("18", "Rachel", "Clark", 54000),
      new Employee("19", "Steven", "Lewis", 47000),
      new Employee("20", "Tina", "Walker", 61000),
    };

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> GetAllEmployees()
    {
      return Ok(Employees);
    }

    [HttpGet("{id}")]
    public ActionResult<EmployeeDetails> GetEmployeeById(string id)
    {
      var employee = Employees.FirstOrDefault(e => e.Id == id);
      if (employee == null)
        return NotFound($"Employee with id {id} not found");

      var taxRate = 0.25;
      var annualTaxPaid = employee.GrossAnnualSalary * taxRate;
      var netAnnualSalary = employee.GrossAnnualSalary - annualTaxPaid;

      var details = new EmployeeDetails
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

      return Ok(details);
    }

    public record Employee(string Id, string FirstName, string LastName, double GrossAnnualSalary);

    public record EmployeeDetails : Employee
    {
      public EmployeeDetails() : base("", "", "", 0) { }

      public double GrossMonthlySalary { get; set; }
      public double AnnualTaxPaid { get; set; }
      public double MonthlyTaxPaid { get; set; }
      public double NetAnnualSalary { get; set; }
      public double NetMonthlySalary { get; set; }
    }
  }
}
