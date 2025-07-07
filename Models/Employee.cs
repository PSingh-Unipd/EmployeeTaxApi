// Models/Employee.cs
namespace Api.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GrossAnnualSalary { get; set; }

        public Employee(string id, string firstName, string lastName, double grossAnnualSalary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            GrossAnnualSalary = grossAnnualSalary;
        }
    }
}
