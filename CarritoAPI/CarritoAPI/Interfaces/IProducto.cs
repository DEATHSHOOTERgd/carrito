using CarritoAPI.Models;

namespace CarritoAPI.Interfaces
{
    public interface IProducto
    {
        public Task<List<ProductoModel>> GetProductos(int categoriaId);
        public Task<ProductoModel> GetProducto(int productoId);

    }
}
