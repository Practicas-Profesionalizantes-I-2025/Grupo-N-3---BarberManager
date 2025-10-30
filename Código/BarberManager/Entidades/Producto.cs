namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; } //PK

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }    //Stock disponible del producto

        public bool usoInterno { get; set; } //Indica si el producto es solo para uso interno de la barbería

        public float Precio { get; set; }

        public List<Promocion_Producto> Promociones { get; set; } = new(); //Relación muchos a muchos con Promoción(a través de la tabla intermedia Promocion_Producto)

        public List<Turno_Servicio_Producto> Turnos { get; set; } = new(); //Relación muchos a muchos con Turno (a través de la tabla intermedia Turno_Servicio_Producto)

    }
}
