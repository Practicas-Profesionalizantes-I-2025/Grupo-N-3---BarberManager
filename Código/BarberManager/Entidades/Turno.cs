using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {

        public int Id { get; set; } //PK

        public DateTime Fecha { get; set; }

        public TimeOnly Hora { get; set; }

        public int IdPeluquero { get; set; } //FK - Relación con Peluquero

        public Peluquero Peluquero { get; set; }

        public int IdCliente { get; set; } //FK - Relación con Cliente

        public Cliente Cliente { get; set; }  

        public int? IdPromocion { get; set; } //FK - Relación opcional con Promoción. Acá se puede aplicar una promoción general al turno. Producto y servicio pueden tener sus propias promociones específicas.

        public Promocion Promocion { get; set; }    

        public List<Turno_Servicio_Producto> TurnoServicioProductos { get; set; } = new(); //Relación con la tabla intermedia que vincula Turno, Servicio y Producto

    }
}
