namespace Api.Models
{
    public class EmployeeDetails : Employee
    {
        public EmployeeDetails() : base("", "", "", 0) { }

        public double GrossMonthlySalary { get; set; }
        public double AnnualTaxPaid { get; set; }
        public double MonthlyTaxPaid { get; set; }
        public double NetAnnualSalary { get; set; }
        public double NetMonthlySalary { get; set; }
    }
}
