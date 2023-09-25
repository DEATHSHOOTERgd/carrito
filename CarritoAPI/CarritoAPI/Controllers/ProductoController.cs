using CarritoAPI.Interfaces;
using CarritoAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarritoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProducto iProducto;
        public ProductoController(IProducto _iProducto)
        {
            this.iProducto = _iProducto;
        }

        [Authorize]
        [HttpGet("Categoria/{categoriaId}")]
        public async Task<ActionResult<UsuarioModel>> GetProductos(int categoriaId)
        {
            try
            {
                var productos = await iProducto.GetProductos(categoriaId);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("Producto/{ProductoId}")]
        public async Task<ActionResult<UsuarioModel>> GetProducto(int productoId)
        {
            try
            {
                var producto = await iProducto.GetProductos(productoId);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
