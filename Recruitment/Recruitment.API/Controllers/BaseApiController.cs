using Microsoft.AspNetCore.Mvc;

namespace Recruitment.API.Controllers
{
    [ApiController, 
     Produces("application/json"), 
     Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}