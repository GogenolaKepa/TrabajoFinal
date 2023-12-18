using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Descuento
    {
        private DateTime fecha;
        private int porcentaje;
        private int codigo;
        
        public DateTime Fecha { get { return fecha; } set {  fecha = value; } }
        public int Porcentaje { get {  return porcentaje; } set {  porcentaje = value; } }
        public int Codigo { get => codigo; set { codigo = value; } }
        public Descuento()
        {
            
        }
        public override string ToString()
        {
            return codigo.ToString();
        }
    }
}
