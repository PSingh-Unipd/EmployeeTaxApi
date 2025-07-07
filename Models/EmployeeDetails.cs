namespace Api.Models
{
    public class EmployeeDetails : Employee
    {
        public EmployeeDetails()
            : base("", "", "", 0) { }

        public decimal GrossMonthlySalary { get; set; }
        public decimal AnnualTaxPaid { get; set; }
        public decimal MonthlyTaxPaid { get; set; }
        public decimal NetAnnualSalary { get; set; }
        public decimal NetMonthlySalary { get; set; }
    }
}
