using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CarritoDetalle : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoDetalleID {  get; set; }
        public int Cantidad { get; set; }
        public int CarritoID { get; set; }
        public int ProductoID { get; set; }
        [ForeignKey("CarritoID")]
        public Carrito Carrito {  get; set; }
        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }

        public CarritoDetalle():base() { }
    }
}
