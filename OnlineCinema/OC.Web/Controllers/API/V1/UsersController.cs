using Microsoft.AspNetCore.Mvc;
using OC.Application.Services.Intefaces;
using System.Threading.Tasks;

namespace OC.Web.Controllers.API.V1
{
    [ApiVersion("1.0")]
    public class UsersController : APIBaseController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Result(users.Data);
        }
    }
}