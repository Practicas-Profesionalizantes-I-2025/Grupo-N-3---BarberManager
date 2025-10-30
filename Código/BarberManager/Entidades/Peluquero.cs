using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Peluquero
    {
        public int Id { get; set; } //PK

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Contrasenia { get; set; }

        public bool EsAdmin { get; set; } //Indica si el peluquero tiene permisos de administrador

        public bool EstaActivo { get; set; } //Estado del peluquero (activo o inactivo en el sistema)

        public List<Turno> Turnos { get; set; } = new(); //Uno a muchos: un peluquero puede tener varios turnos asignados

    }
}
