using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class EComerceDBContext:DbContext
    {
        public EComerceDBContext(DbContextOptions<EComerceDBContext> options):
            base(options){}

        public DbSet<Carrito> Carritos {  get; set; }
        public DbSet<CarritoDetalle> CarritoDetalles { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}