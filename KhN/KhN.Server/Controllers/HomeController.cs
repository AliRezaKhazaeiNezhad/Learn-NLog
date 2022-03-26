using Microsoft.AspNetCore.Mvc;

namespace KhN.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogCritical("Hello, this is the index!");
            return "Hello World";
        }
    }
}
