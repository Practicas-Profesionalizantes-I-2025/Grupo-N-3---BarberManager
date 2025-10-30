using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion
    {

        public int Id { get; set; } //PK

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public float DescuentoPorcentaje { get; set; } //Porcentaje de descuento aplicado (por ejemplo: 10 = 10%)

        public DateTime FechaInicio { get; set; } //Fecha desde la cual la promoción comienza a ser válida

        public DateTime FechaFin { get; set; } //Fecha hasta la cual la promoción está vigente

        public List<Promocion_Servicio> Servicios { get; set; } = new(); //Relación muchos a muchos con Servicio (a través de la tabla intermedia Promocion_Servicio)

        public List<Promocion_Producto> Productos { get; set; } = new(); //Relación muchos a muchos con Producto (a través de la tabla intermedia Promocion_Producto)

        public List<Turno> Turnos { get; set; } = new(); // Relación uno a muchos: una promoción puede estar asociada a varios turnos

    }
}
