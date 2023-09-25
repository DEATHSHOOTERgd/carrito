using CarritoAPI.Interfaces;
using CarritoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.Metrics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarritoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogin iLogin;
        public LoginController(ILogin _iLogin) {
            this.iLogin = _iLogin;
        }


        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Login(LoginModel loginModel)
        {
            try
            {
                var usuario = await iLogin.Login(loginModel.Correo, loginModel.Password);
                return Ok(usuario);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
