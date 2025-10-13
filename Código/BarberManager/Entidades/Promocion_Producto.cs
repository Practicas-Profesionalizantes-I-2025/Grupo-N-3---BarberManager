using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Promocion_Producto
    {
        public int IdPromocion { get; set; }

        public Promocion Promocion { get; set; }

        public int IdProducto { get; set; }

        public Producto Producto { get; set; }

    }
}
