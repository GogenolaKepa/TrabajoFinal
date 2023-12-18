using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ProductoNoPerecedero : Producto
    {
        public ProductoNoPerecedero()
        {
        }

        private int pasillo;
        public int Pasillo { get { return pasillo; } set { pasillo = value; } }
    }
}