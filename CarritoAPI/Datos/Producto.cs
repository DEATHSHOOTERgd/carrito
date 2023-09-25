using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        public string Detalle { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        [Comment("Puede ser 'S' o 'N'. 'S' para los productos que gravan iva y 'N' para los que no.")]
        public char GravaIVA {  get; set; }
        public double PorcIVA { get; set; }
        public string UrlImagen { get; set; }
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public Categoria Categoria { get; set; }
        public Producto() : base() { }
    }
}
