using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioDescuento
    {
        private List<Descuento> descuentos;
        public RepositorioDescuento()
        {
            descuentos = new List<Descuento>();
           
        }


        private static RepositorioDescuento instancia;
        public static RepositorioDescuento Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioDescuento();
                return instancia;
            }
        }

        public ReadOnlyCollection<Descuento> Descuentos { get => descuentos.AsReadOnly(); }
        
        public void AgregarDescuento(Descuento descuento)
        {
            descuentos.Add(descuento);
        }
        public bool EliminarDescuento(int codigo)
        {
            var descuentoExistente = BuscarCodigo(codigo);
            if (descuentoExistente != null)
            {
                descuentos.Remove(descuentoExistente);
                return true;
            }
            return false;
        }
        public Descuento BuscarCodigo(int codigo)
        {
            return descuentos.FirstOrDefault(descuentos => descuentos.Codigo == codigo);
        }
        public ReadOnlyCollection<Descuento> ObtenerDescuentos()
        {
            return descuentos.ToList().AsReadOnly();
        }
           
    }
}
