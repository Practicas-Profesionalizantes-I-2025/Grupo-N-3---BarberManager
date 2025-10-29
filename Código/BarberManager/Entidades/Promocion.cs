using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public float DescuentoPorcentaje { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public List<Promocion_Servicio> Servicios { get; set; } = new(); 

        public List<Promocion_Producto> Productos { get; set; } = new();

        public List<Turno> Turnos { get; set; } = new();

    }
}
