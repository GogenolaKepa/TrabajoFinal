using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioEmpleado
    {
        private List<Empleado> empleados;

        public RepositorioEmpleado()
        {
            empleados = new List<Empleado>();
        }
        public ReadOnlyCollection<Empleado> Empleados { get => empleados.AsReadOnly(); }

        private static RepositorioEmpleado instancia;
        public static RepositorioEmpleado Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioEmpleado();
                return instancia;
            }
        }
        public bool Agregar(Empleado empleado)
        {
            var empleadoExistente = Buscar(empleado.Dni);

            //Comprobacion de que no exista el DNI en lista empleados
            if (empleadoExistente == null)
            {
                empleados.Add(empleado);
                return true;
            }
            return false;
        }

        public bool Eliminar(int dni)
        {
            var empleadoExistente = Buscar(dni);

            //Comprobacion de que exista el dni en lista empleados
            if (empleadoExistente != null)
            {
                empleados.Remove(empleadoExistente);
                return true;
            }
            return false;
        }

        public Empleado Buscar(int dni)
        {
            return empleados.FirstOrDefault(empleado => empleado.Dni == dni);
        }
        public ReadOnlyCollection<Empleado> ObtenerEmpleados()
        {
            return empleados.ToList().AsReadOnly();
        }
        public Empleado BuscarApellido (string apellido)
        {
            return empleados.FirstOrDefault(empleado => empleado.Apellido == apellido);
        }
    }
}
