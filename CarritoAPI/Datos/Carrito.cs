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
    public  class Carrito : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID {  get; set; }
        [Comment("Puede ser 'P' (pendiente) o 'C' (cerrado).")]
        public char EstadoCarrito { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public Usuario Usuario { get; set; }
        public ICollection<CarritoDetalle> CarritoDetalles { get; set; }

        public Carrito():base() { }
    }
}
