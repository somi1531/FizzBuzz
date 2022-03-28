using Microsoft.AspNetCore.Mvc;
using System;

namespace usage.tracking.request.service.Controllers
{
    public class HealthController : ControllerBase
    {
        public HealthController() 
        {

        }

        [HttpGet]
        [Route("tracking/health/v1")]
        public ActionResult<string> GetHealth()
        {
            return Ok("Running");
        }
       
    }
}
