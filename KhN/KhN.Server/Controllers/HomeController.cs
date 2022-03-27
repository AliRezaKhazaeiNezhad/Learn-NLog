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
            _logger.LogInformation("NLog injected into HomeController");
        }

        [HttpGet]
        public string Get()
        {
            #region Session21
            //_logger.LogTrace("Hello, this is the Trace!");
            //_logger.LogDebug("Hello, this is the Debug!");
            //_logger.LogWarning("Hello, this is the Warning!");
            //_logger.LogInformation("Hello, this is the Information!");
            //_logger.LogError("Hello, this is the Erorr!");
            //_logger.LogCritical("Hello, this is the Fatal(Critical)!");
            #endregion


            #region Session22
            _logger.LogCritical("Hello, this is the Fatal(Critical)!");
            _logger.LogCritical("Hello, this is the Fatal");
            #endregion

            return "Hello World";
        }
    }
}
