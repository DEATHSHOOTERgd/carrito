using Datos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarritoAPI.Models
{
    public class ProductoModel
    {
        public int ID { get; set; }
        public string Detalle { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public char GravaIVA { get; set; }
        public string PorcIVA { get; set; }
        public string UrlImagen { get; set; }
        public string Categoria { get; set; }
    }
}
