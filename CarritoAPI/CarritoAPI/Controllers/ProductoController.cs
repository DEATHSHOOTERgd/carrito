using CarritoAPI.Interfaces;
using CarritoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarritoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> GetProductos(int categoriaId)
        {
            try
            {
                //var usuario = await iLogin.Login(loginModel.Correo, loginModel.Password);
                //return Ok(usuario);
                return null;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
