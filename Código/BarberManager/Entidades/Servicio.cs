using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    { 
        public int Id { get; set; } //PK

        public string Nombre { get; set; }

        public float Precio { get; set; }

        public List<Turno_Servicio_Producto> TurnoServicioProductos { get; set; } = new(); //Relación con la tabla intermedia que vincula Turno, Servicio y Producto

        public List<Promocion_Servicio> Promociones { get; set; } = new(); //Relación muchos a muchos entre Servicio y Promoción

    }
}
