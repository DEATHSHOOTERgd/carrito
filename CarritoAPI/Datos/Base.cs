using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Base
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualiza { get; set; }
        [Comment("Puede ser 'A' para activo o 'I' para inactivo.")]
        public char Estado {  get; set; }
        protected Base() {
            this.FechaCreacion = DateTime.UtcNow;
            this.Estado = 'A';
        }
    }
}
