using Microsoft.AspNetCore.Mvc;
using OC.Application.Results;

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

        protected IActionResult Result(object data)
        {
            if (data != null)
                return ResultOk(data);
            return ResultNotFound(data);
        }

        private IActionResult ResultOk(object data)
        {
            return Ok(data);
        }
        private IActionResult ResultNotFound(object data)
        {
            return Ok(data);
        }
    }
}
