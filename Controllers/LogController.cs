using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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
            Logger.LogInformation("Logger is runnig");
            return StatusCode(202);

        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            throw new Exception("Somethinks went wrong");

        }

        [HttpGet("Res")]
        public IActionResult Res()
        {
            Logger.LogError(new Exception(), "Error");
            return null;

        }
    }
}