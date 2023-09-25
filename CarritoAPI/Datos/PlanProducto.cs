using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PlanProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanProductoID { get; set; }
        public int PlanID { get; set; }
        public int ProductoID { get; set; }
        [ForeignKey("PlanID")]
        public Plan Plan { get; set; }
        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }
        public PlanProducto():base() { }
    }
}
