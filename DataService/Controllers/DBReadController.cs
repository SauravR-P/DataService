using DataService.CQRS.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DataService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBReadController : ControllerBase
    {
        private readonly ILogger<DBReadController> _logger;
        private readonly IMediator _mediator;

        public DBReadController(ILogger<DBReadController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
      
        }

        [HttpGet(Name = "GetAllEmpRecord")]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllRecordsQuery());
                return response == null ? NotFound() : Ok(response);
        }
    }
}