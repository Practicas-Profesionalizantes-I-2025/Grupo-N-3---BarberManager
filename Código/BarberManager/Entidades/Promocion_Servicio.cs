using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion_Servicio
    {

        public int IdPromocion { get; set; } //FK hacia Promocion (una promoción puede aplicarse a varios servicios)

        public Promocion Promocion { get; set; }

        public int IdServicio { get; set; } //FK hacia la tabla Servicio (un servicio puede estar en varias promociones)

        public Servicio Servicio { get; set; }

    }
}
