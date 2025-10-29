using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    { 
        public int Id { get; set; }

        public string Nombre { get; set; }

        public float Precio { get; set; }

        public List<Turno_Servicio_Producto> TurnoServicioProductos { get; set; } = new();

        public List<Promocion_Servicio> Promociones { get; set; } = new();

    }
}
