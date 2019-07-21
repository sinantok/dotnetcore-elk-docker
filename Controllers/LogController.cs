using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetCoreELK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private ILogger<LogController> Logger { get; set; }

        public LogController(ILogger<LogController> _logger)
        {
            this.Logger = _logger;
        }

        [HttpGet("Info")]
        public IActionResult Index()
        {
            Logger.LogInformation("Somethink went wrong");
            return null;

        }
    }
}