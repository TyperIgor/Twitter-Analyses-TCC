using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net;

namespace TwitterAnalysis.Host.Controllers.HealthCheck
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class HealthController : Controller
    {
        private readonly HealthCheckService _healthCheck;

        public HealthController(HealthCheckService healthCheck)
        {
            _healthCheck = healthCheck;
        }

        [HttpGet()]
        public async Task<IActionResult> Get() => Ok(await _healthCheck.CheckHealthAsync());
        
    }
}
