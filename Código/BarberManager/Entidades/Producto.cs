namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }   

        public bool usoInterno { get; set; }

        public float Precio { get; set; }

        public List<Promocion_Producto> Promociones { get; set; } = new();

        public List<Turno_Servicio_Producto> Turnos { get; set; } = new();


    }
}
