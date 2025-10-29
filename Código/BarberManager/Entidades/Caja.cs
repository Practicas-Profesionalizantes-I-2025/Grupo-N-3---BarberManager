using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        public int Id { get; set; }

        public DateTime FechaInicio { get; set; }
        
        public DateTime? FechaCierre { get; set; }

        public decimal Ingresos { get; set; }

        public decimal Egresos { get; set; }

    }
}
