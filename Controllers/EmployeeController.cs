using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(
            ILogger<EmployeeController> logger,
            IEmployeeService employeeService
        )
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(_employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeDetails> GetEmployeeById(string id)
        {
            var details = _employeeService.GetEmployeeDetails(id);
            if (details == null)
                return NotFound($"Employee with id {id} not found");

            return Ok(details);
        }

        [HttpPut("{id}/salary")]
        public IActionResult UpdateSalary(string id, [FromBody] UpdateSalaryRequest request)
        {
            if (request == null || request.NewSalary <= 0)
            {
                return BadRequest("Invalid salary value.");
            }

            var updated = _employeeService.UpdateSalary(id, request.NewSalary);

            if (!updated)
            {
                return NotFound($"Employee with id {id} not found.");
            }

            return NoContent();
        }
    }
}
