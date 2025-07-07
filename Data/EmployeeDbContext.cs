using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Employee>()
                .HasData(
                    new Employee
                    {
                        Id = "1",
                        FirstName = "Alice",
                        LastName = "Johnson",
                        GrossAnnualSalary = 50000,
                    },
                    new Employee
                    {
                        Id = "2",
                        FirstName = "Bob",
                        LastName = "Smith",
                        GrossAnnualSalary = 60000,
                    },
                    new Employee
                    {
                        Id = "3",
                        FirstName = "Charlie",
                        LastName = "Brown",
                        GrossAnnualSalary = 45000,
                    },
                    new Employee
                    {
                        Id = "4",
                        FirstName = "Diana",
                        LastName = "Reed",
                        GrossAnnualSalary = 70000,
                    },
                    new Employee
                    {
                        Id = "5",
                        FirstName = "Ethan",
                        LastName = "Cole",
                        GrossAnnualSalary = 55000,
                    },
                    new Employee
                    {
                        Id = "6",
                        FirstName = "Fiona",
                        LastName = "Black",
                        GrossAnnualSalary = 80000,
                    },
                    new Employee
                    {
                        Id = "7",
                        FirstName = "George",
                        LastName = "White",
                        GrossAnnualSalary = 48000,
                    },
                    new Employee
                    {
                        Id = "8",
                        FirstName = "Hannah",
                        LastName = "Green",
                        GrossAnnualSalary = 75000,
                    },
                    new Employee
                    {
                        Id = "9",
                        FirstName = "Ian",
                        LastName = "Blue",
                        GrossAnnualSalary = 52000,
                    },
                    new Employee
                    {
                        Id = "10",
                        FirstName = "Julia",
                        LastName = "Gray",
                        GrossAnnualSalary = 63000,
                    },
                    new Employee
                    {
                        Id = "11",
                        FirstName = "Kevin",
                        LastName = "Brown",
                        GrossAnnualSalary = 47000,
                    },
                    new Employee
                    {
                        Id = "12",
                        FirstName = "Laura",
                        LastName = "Wright",
                        GrossAnnualSalary = 67000,
                    },
                    new Employee
                    {
                        Id = "13",
                        FirstName = "Michael",
                        LastName = "King",
                        GrossAnnualSalary = 53000,
                    },
                    new Employee
                    {
                        Id = "14",
                        FirstName = "Nina",
                        LastName = "Young",
                        GrossAnnualSalary = 49000,
                    },
                    new Employee
                    {
                        Id = "15",
                        FirstName = "Oscar",
                        LastName = "Hall",
                        GrossAnnualSalary = 58000,
                    },
                    new Employee
                    {
                        Id = "16",
                        FirstName = "Paula",
                        LastName = "Scott",
                        GrossAnnualSalary = 76000,
                    },
                    new Employee
                    {
                        Id = "17",
                        FirstName = "Quentin",
                        LastName = "Moore",
                        GrossAnnualSalary = 62000,
                    },
                    new Employee
                    {
                        Id = "18",
                        FirstName = "Rachel",
                        LastName = "Clark",
                        GrossAnnualSalary = 54000,
                    },
                    new Employee
                    {
                        Id = "19",
                        FirstName = "Steven",
                        LastName = "Lewis",
                        GrossAnnualSalary = 47000,
                    },
                    new Employee
                    {
                        Id = "20",
                        FirstName = "Tina",
                        LastName = "Walker",
                        GrossAnnualSalary = 61000,
                    }
                );
        }
    }
}
