using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno_Servicio_Producto
    {

        public int IdTurno { get; set; } //FK hacia Turno - indica a qué turno pertenece esta relación

        public Turno Turno { get; set; }

        public int? IdServicio { get; set; } //FK hacia Servicio - indica qué servicio se realizó en el turno

        public Servicio Servicio { get; set; }

        public int? IdProducto { get; set; } //FK hacia Producto - indica qué producto se utilizó en el turno

        public Producto Producto { get; set; }

        public int CantidadProducto { get; set; } //Cantidad de unidades del producto utilizadas o vendidas en el turno

        public float PrecioUnitario { get; set; } //Precio unitario del producto o servicio en el momento del turno

        public float Subtotal { get; set; } //Monto total resultante (CantidadProducto * PrecioUnitario)

    }
}
