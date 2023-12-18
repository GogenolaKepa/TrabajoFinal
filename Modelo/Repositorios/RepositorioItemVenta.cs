using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepositorioItemVenta
    {
       //Hay q borrar el repositorio entero?
        private List<ItemVenta> itemVentas;
        private RepositorioProducto repositorioProductos;
        public RepositorioItemVenta()
        {
            itemVentas = new List<ItemVenta>();
            repositorioProductos = new RepositorioProducto();
        }

        private static RepositorioItemVenta instancia;
        public static RepositorioItemVenta Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioItemVenta();
                return instancia;
            }
        }
        public ReadOnlyCollection<ItemVenta> ItemVentas { get => itemVentas.AsReadOnly(); }


        public bool Agregar(ItemVenta venta)
        {
            itemVentas.Add(venta);
            return true;
        }


    
        /*public bool Eliminar(int codigo)
        {
            var ventaExistente = Buscar(codigo);

            //Comprobacion de que exista el codigo en lista ventas
            if (ventaExistente != null)
            {
                itemVentas.Remove(ventaExistente);
                return true;
            }

            return false;
        }*/
        /*public ItemVenta Buscar(int codigo)
        {
            return itemVentas.FirstOrDefault(itemVentas => itemVentas.Codigo == codigo);
        }*/
        public List<ItemVenta> ObtenerItemsVenta()
        {
            return itemVentas.ToList();
        }
    }
}