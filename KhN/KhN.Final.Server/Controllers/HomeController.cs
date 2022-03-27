using Microsoft.AspNetCore.Mvc;

namespace KhN.Final.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("NLog injected into HomeController");
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogCritical("This is Test");
            return "Hello World";
        }
    }
}
