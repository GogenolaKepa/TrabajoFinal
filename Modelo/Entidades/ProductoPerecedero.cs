using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ProductoPerecedero : Producto
    {
        public ProductoPerecedero()
        {
        }
        private DateTime fechaVencimiento;
        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }
    }
}