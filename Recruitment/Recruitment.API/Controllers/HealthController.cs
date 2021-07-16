using Microsoft.AspNetCore.Mvc;

namespace Recruitment.API.Controllers
{
    public class HealthController : BaseApiController
    {
        [HttpGet("check")]
        public string Get()
        {
            return "still alive";
        }
    }
}
