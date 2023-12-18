using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ItemVenta
    {
        private Producto producto;
        private int cantidad;
        public Producto Producto { get {return producto; } set { producto = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
    
        public ItemVenta()
        {
                       
        }
       
    }
}