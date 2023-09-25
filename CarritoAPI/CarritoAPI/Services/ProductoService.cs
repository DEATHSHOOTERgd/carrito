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

        public async Task<ProductoModel> GetProducto(int productoId)
        {
            var producto = await _context.Productos.Where(p => p.ProductoID == productoId && p.Estado != 'I').FirstOrDefaultAsync();
            if (producto==null)
            {
                throw new Exception("No existe producto con ese ID o ya no se encuentra disponible.");
            }

            return new ProductoModel{
                ID = producto.ProductoID,
                Detalle = producto.Detalle,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio.ToString(),
                GravaIVA = producto.GravaIVA,
                PorcIVA = producto.PorcIVA.ToString(),
                UrlImagen = producto.UrlImagen,
                Categoria = producto.CategoriaID,
            };
        }

        public async Task<List<ProductoModel>> GetProductos(int categoriaId=0)
        {
            var productosMap = new List<ProductoModel>();
            var productos = await _context.Productos.Where(p=>p.CategoriaID==categoriaId && p.Estado!='I').ToListAsync();
            foreach (var producto in productos) {
                productosMap.Add(new ProductoModel
                {
                    ID=producto.ProductoID,
                    Detalle = producto.Detalle,
                    Descripcion = producto.Descripcion,
                    Precio=producto.Precio.ToString(),
                    GravaIVA=producto.GravaIVA,
                    PorcIVA=producto.PorcIVA.ToString(),
                    UrlImagen=producto.UrlImagen,
                    Categoria = producto.CategoriaID,
                });
            }
            return productosMap;
        }
    }
}
