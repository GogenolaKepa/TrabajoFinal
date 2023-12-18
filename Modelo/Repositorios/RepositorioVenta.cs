using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVenta
    {
        private List<Venta> ventas;

        private static RepositorioVenta instancia;
        public static RepositorioVenta Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioVenta();
                return instancia;
            }
        }
        public RepositorioVenta()
        {
            ventas = new List<Venta>();
        }
        public bool Agregar(Venta venta)
        {
            ventas.Add(venta);
            return true;
        }
       public ReadOnlyCollection<Venta> ObtenerVentas()
        {
            return ventas.ToList().AsReadOnly();
        }
        
    }
}
