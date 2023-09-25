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
    public  class Plan : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanID { get; set; } 
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public string Descripcion { get; set; }
        [Comment("Puede ser 'M' mensual, 'B' bimensual o 'A' anual")]
        public char Frecuencia { get; set; }
        public double Valor { get; set; }
        public Plan():base() { }
    }
}
