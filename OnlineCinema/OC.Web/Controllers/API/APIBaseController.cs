using Microsoft.AspNetCore.Mvc;

namespace OC.Web.Controllers.API
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class APIBaseController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok($"{HttpContext.Request.Path.Value} {HttpContext.Connection.RemoteIpAddress}");
        }
    }
}
