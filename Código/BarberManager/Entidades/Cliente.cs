using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; } //PK

        public string Nombre { get; set; } //Nombre completo del cliente

        public string Telefono { get; set; }

        public string? Correo { get; set; } //Puede ser nulo si el cliente no lo proporciona

        public List<Turno> Turnos { get; set; } = new(); //Uno a muchos: un cliente puede tener varios turnos

    }
}
