using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {

        public int Id { get; set; } //PK

        public string NombreDia { get; set; } //Nombre del día (por ejemplo: "Lunes", "Martes", etc.)

        public DateTime Fecha { get; set; }

        public int CantServicios { get; set; } //Cantidad de servicios realizados en esa fecha

        public int CantVentas { get; set; } //Cantidad de ventas registradas en esa fecha

    }
}
