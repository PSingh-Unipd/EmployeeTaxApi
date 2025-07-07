using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Employee
    {
        public Employee() { }

        public Employee(string id, string firstName, string lastName, decimal grossAnnualSalary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            GrossAnnualSalary = grossAnnualSalary;
        }

        [Key]
        public required string Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public decimal GrossAnnualSalary { get; set; }
    }
}
