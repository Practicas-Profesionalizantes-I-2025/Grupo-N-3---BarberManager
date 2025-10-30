using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        public int Id { get; set; } //PK

        public DateTime FechaInicio { get; set; }
        
        public DateTime? FechaCierre { get; set; } // Puede ser nula si la caja aún está abierta o en proceso.

        public decimal Ingresos { get; set; }

        public decimal Egresos { get; set; }

    }
}
