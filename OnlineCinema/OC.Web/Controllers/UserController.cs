using Microsoft.AspNetCore.Mvc;
using OC.Application.Services.Intefaces;
using OC.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OC.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("users")]
        public async Task<IActionResult> Index()
        {
            var result = await _userService.GetAllUsersAsync();
            if (result.IsOK)
                return View(result.Data as List<UserViewModel>);
            return View(null);
        }
    }
}
