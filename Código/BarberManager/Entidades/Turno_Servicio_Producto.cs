using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno_Servicio_Producto
    {

        public int IdTurno { get; set; }

        public Turno Turno { get; set; }

        public int? IdServicio { get; set; }

        public Servicio Servicio { get; set; }

        public int? IdProducto { get; set; } 

        public Producto Producto { get; set; }

        public int CantidadProducto { get; set; }

        public float PrecioUnitario { get; set; }

        public float Subtotal { get; set; } 

    }
}
