using DataService.Model;
using Microsoft.AspNetCore.Mvc;

namespace DataService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBReadController : ControllerBase
    {
        private readonly ILogger<DBReadController> _logger;
        private EmployeeDbContext _employeeDbContext;

        public DBReadController(ILogger<DBReadController> logger, EmployeeDbContext employeeDbContext)
        {
            _logger = logger;
            _employeeDbContext = employeeDbContext;
        }

        [HttpGet(Name = "GetAllEmpRecord")]
        public IEnumerable<Employee> Get()
        {
            return _employeeDbContext.Employee;
        }
    }
}