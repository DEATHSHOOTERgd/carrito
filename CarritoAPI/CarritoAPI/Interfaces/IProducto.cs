using CarritoAPI.Models;

namespace CarritoAPI.Interfaces
{
    public interface IProducto
    {
        public Task<ProductoModel> GetProductos(int categoria);
        
    }
}
