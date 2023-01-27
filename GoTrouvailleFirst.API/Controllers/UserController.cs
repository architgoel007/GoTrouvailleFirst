using GoTrouvailleFirst.BL.InterfaceBL;
using GoTrouvailleFirst.DL.Model;
using GoTrouvailleFirst.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GoTrouvailleFirst.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBLUserService _bLUserService;

        public UserController(IBLUserService bLUserService)
        {
            _bLUserService = bLUserService;
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(UserDto userDto)
        {
            _bLUserService.AddUser(userDto);
            return Ok(userDto);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(UserDto userDto)
        {
            _bLUserService.UpdateUser(userDto);
            return Ok(userDto);
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            _bLUserService.DeleteUser(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public IActionResult GetById(Guid id)
        {
            UserDto? userDto = _bLUserService.UserGetById(id);
            return Ok(userDto);
        }

        [HttpGet]
        [Route("GetAllUser")]
        public IActionResult GetAllUser()
        {
            List<UserDto>? users = _bLUserService.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            List<Country>? countries = _bLUserService.GetCountries();
            return Ok(countries);
        }

        [HttpGet]
        [Route("GetAllStates")]
        public IActionResult GetAllStates()
        {
            List<State>? states = _bLUserService.GetStates();
            return Ok(states);
        }
    }
}
