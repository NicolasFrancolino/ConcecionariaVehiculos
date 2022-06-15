using ConcecionariaVehiculos.Entities;
using ConcecionariaVehiculos.Modelo.User;
using ConcecionariaVehiculos.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Authorization;

namespace ConcecionariaVehiculos.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);
            return Ok(response);
        }

        [Authorize(Role.Admin)]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [Authorize(Role.User, Role.Admin)]
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            // only admins can access other user records
            /*   var currentUser = (User)HttpContext.Items["User"];
               if (id != currentUser.Id && currentUser.Role != Role.Admin)
                   return Unauthorized(new { message = "Unauthorized" });
               */
            var user = _userService.GetById(id);
            return Ok(user);
        }
    }
}
