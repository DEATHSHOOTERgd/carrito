using CarritoAPI.Interfaces;
using CarritoAPI.Models;
using Datos;
using Microsoft.EntityFrameworkCore;

namespace CarritoAPI.Services
{
    public class ProductoService : IProducto
    {
        private readonly EComerceDBContext _context;

        public ProductoService(EComerceDBContext context)
        {
            this._context = context;
        }

        public async Task<ProductoModel> GetProductos(int categoria=0)
        {
            var productosMap = new List<ProductoModel>();
            var productos = _context.Productos.ToListAsync();
            //foreach (var producto in productos) {

            //}
            return null;

        }
    }
}
