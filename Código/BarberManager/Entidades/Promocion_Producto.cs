using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion_Producto
    {
        public int IdPromocion { get; set; } //FK hacia la tabla Promocion (una promoción puede aplicarse a varios productos)

        public Promocion Promocion { get; set; }

        public int IdProducto { get; set; } //FK hacia la tabla Producto (un producto puede estar en varias promociones)

        public Producto Producto { get; set; }

    }
}
