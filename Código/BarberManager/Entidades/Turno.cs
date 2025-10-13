using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {

        public int Id { get; set; }

        public DateTime FechaYHora { get; set; }

        public int IdPeluquero { get; set; }

        public Peluquero Peluquero { get; set; }

        public int IdCliente { get; set; }

        public Cliente Cliente { get; set; }  

        public int IdPromocion { get; set; }

        public Promocion Promocion { get; set; }    

    }
}
