# Employee Tax API

A simple ASP.NET Core Web API to manage employee data and calculate tax-related salary details based on a simplified custom tax band system.

## Features

- Retrieve all employees
- Get an employee by ID
- Update employee salary
- Calculate net salary and tax based on gross annual salary
- Uses Entity Framework Core with Code-First approach
- Database is seeded with 20 dummy employees at startup

## Technologies

- ASP.NET Core Web API
- Entity Framework Core (Code First)
- SQL Server / In-Memory DB (depending on configuration)
- C#
- Swagger (OpenAPI)

---

## Tax Calculation Logic

This project uses a simplified UK income tax band model:

| Band | Salary Range (£)  | Tax Rate (%) |
| ---- | ----------------- | ------------ |
| A    | £0 - £5,000       | 0%           |
| B    | £5,001 - £20,000  | 20%          |
| C    | £20,001 and above | 40%          |

Tax is calculated incrementally per band.

---

## Setup

Follow these steps to get the project running locally.

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [EF Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) (optional, for migration commands)
- SQL Server Express installed and running with the SQLEXPRESS instance, or SQL Server Express LocalDB

Ensure your connection string in appsettings.json matches your SQL Server instance (default is: "Server=localhost\\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=True;TrustServerCertificate=True;")

---

### 1. Clone and Run the Project

```bash
# Clone the repository
git clone https://github.com/PSingh-Unipd/EmployeeTaxApi.git

# Navigate into the project directory
cd EmployeeTaxApi

# Apply the latest Entity Framework Core migrations to create the database
dotnet ef database update

# Run the API
dotnet run
```
