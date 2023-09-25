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
    public class PlanUsuario : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanUsuarioID { get; set; }
        public int PlanID { get; set; }
        public int UsuarioID { get; set; }
        public double Consumido { get; set; }
        [ForeignKey("PlanID")]
        public Plan Plan { get; set; }
        [ForeignKey("UsuarioID")]
        public Usuario Usuario { get; set; }
        public PlanUsuario() : base() { }
    }
}
