using Amanah.DAL.Models;
using Amanah.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Amanah.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserBLL _userBll;
        public LoginController(IUserBLL userBll)
        {
            _userBll = userBll;
        }
        [HttpPost]
        public IActionResult Login([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }
            User loginUser = _userBll.Login(user.Name, user.Password);
            if (loginUser!=null)
                {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signingcredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "",
                    audience: "",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signingcredentials
                    );
                var tokenStr = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenStr, loginUser });
            }
            return Unauthorized();
        }


    }
}
