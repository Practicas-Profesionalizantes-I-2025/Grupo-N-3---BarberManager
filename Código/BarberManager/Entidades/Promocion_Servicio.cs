using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion_Servicio
    {

        public int IdPromocion { get; set; }

        public Promocion Promocion { get; set; }

        public int IdServicio { get; set; } 

        public Servicio Servicio { get; set; }

    }
}
