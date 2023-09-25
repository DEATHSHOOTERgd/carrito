using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DbSeeder
    {
        public static void SeedData(EComerceDBContext context)
        {
            if (!context.Categorias.Any())
            {
                context.Categorias.Add(new Categoria { Nombre = "Tecnología" });
                context.Categorias.Add(new Categoria { Nombre = "Ropa" });
                context.Categorias.Add(new Categoria { Nombre = "Calzado" });

                context.SaveChanges();
            }
            if (!context.Productos.Any())
            {
                context.Productos.Add(new Producto { Detalle = "Laptop", Descripcion="Laptop HP con Windows 11 y Licencia de MS Office 365.", GravaIVA='S', Precio=406.50, PorcIVA=12.00, CategoriaID=1, UrlImagen= "https://point.com.ec/wp-content/uploads/2022/06/14DV0503LA.jpg" });
                context.Productos.Add(new Producto { Detalle = "Camisa Nike Tee", Descripcion = "Camisa negra de la nueva línea Tee de Nike con un diseño minimalista.", GravaIVA = 'S', Precio = 25.66, PorcIVA = 12.00, CategoriaID = 2, UrlImagen = "https://images.stylight.net/image/upload/e_trim/t_web_product_330x440max_nobg/q_auto:eco,f_auto/foxhfb9vyiuleqc45n2x.jpg" });
                context.Productos.Add(new Producto { Detalle = "Nike SB Chron 2", Descripcion = "Zapatos para skaters de la línea SB de Nike.", GravaIVA = 'S', Precio = 60.00, PorcIVA = 12.00, CategoriaID = 3, UrlImagen = "https://media.marathon.store/products/h94/h68/h00/9914504249374.jpg" });

                context.SaveChanges();
            }
            if (!context.Usuarios.Any())
            {
                context.Usuarios.Add(new Usuario { NombreUsuario="Giampaolo", Email="giampaolo.delgadoo@gmail.com", Password= BCrypt.Net.BCrypt.HashPassword("password") });

                context.SaveChanges();
            }
        }
    }
}
