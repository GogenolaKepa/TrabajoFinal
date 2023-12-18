using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        private string email;
        private string apellido;
        private int dni;
        private int telefono;

        public string Email { get { return email; } set { email = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }

        public Cliente()
        {
           
        }
        public override string ToString()
        {
            return apellido.ToString();
        }
    }
}
