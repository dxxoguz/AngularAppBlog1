using BUSINESS.Contracts;
using BUSINESS.Implemetations;
using DOMAIN.Dtos;
using Microsoft.AspNetCore.Mvc;
using SHARED.Dtos;
using static BUSINESS.Implemetations.AuthBusinessEngine;

namespace AngularAppBlog1.Server.Controllers
{
    [Route("Auth")]
    public class AuthController : Controller
    {
        private readonly IAuthBusinessEngine _authEngine;
        public AuthController(IAuthBusinessEngine authEngine)
        {
            _authEngine = authEngine;
        }
        [HttpPost("AddUser")]
        public AddingUserMessage AddUser([FromBody] UserDto user)
        {
            return this._authEngine.AddUser(user);
        }
        [HttpPost("Login")]
        public LoginUser Login([FromBody]LoginDto loggedUser)
        {
            return this._authEngine.Login(loggedUser);
        }

    }
}
