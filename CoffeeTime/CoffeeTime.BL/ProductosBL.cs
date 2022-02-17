using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeTime.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Cafe Negro";
            producto1.Precio = 35;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Chocolate";
            producto2.Precio = 40;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            return listadeProductos;
        }
    }
}
