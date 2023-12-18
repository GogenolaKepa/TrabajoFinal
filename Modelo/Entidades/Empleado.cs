using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Empleado
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;

        public int Dni { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public Empleado()
        {
           
        }
        public override string ToString()
        {
            return apellido.ToString();
        }
    }
}