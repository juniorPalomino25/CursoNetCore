using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curso_de_net_core
{
    public class Frutas : Almacen
    {
        private List<Producto> _Frutas;
        public Frutas()
        { 
             _Frutas = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            _Frutas.Add(producto);
        }

        public override List<Producto> getProducto(string producto)
        {
            var frutas = new List<Producto>();
            if (producto.Equals(""))
            {
                frutas = _Frutas;
            }
            else
            {
                frutas = _Frutas.Where(g => g.Nombre.Equals(producto)).ToList();
            }
            return frutas;
        }
    }
}
