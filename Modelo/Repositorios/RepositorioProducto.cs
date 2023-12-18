using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepositorioProducto
    {
        private List<Producto> productos;

        public RepositorioProducto()
        {
            productos = new List<Producto>();
        }

        private static RepositorioProducto instancia;
        public static RepositorioProducto Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new RepositorioProducto();
                return instancia;
            }
        }
        public ReadOnlyCollection<Producto> ObtenerProductos()
        {
            return productos.AsReadOnly();
        }

        public bool Agregar(Producto producto)
        {
            var productoExistente = Buscar(producto.Codigo);
            if (productoExistente == null)
            {
                productos.Add(producto);
                return true;
            }
            return false;
        }

        public bool Eliminar(int codigo)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto == null)
            {
                return false;
            }

            productos.Remove(producto);
            return true;
        }

        public bool Modificar(Producto producto)
        {
            var productoExistente = productos.FirstOrDefault(p => p.Codigo == producto.Codigo);
            if (productoExistente == null)
            {
                return false;
            }

            productos.Remove(productoExistente);
            productos.Add(producto);
            return true;
        }

        public List<Producto> ObtenerPerecederos()
        {
            return productos.Where(p => p is ProductoPerecedero).ToList();
        }

        public List<Producto> ObtenerNoPerecederos()
        {
            return productos.Where(p => p is ProductoNoPerecedero).ToList();
        }
      
        public Producto Buscar(int codigo)
        {
            // Busca el producto por código.
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);

            // Si no encuentra el producto, devuelve null.
            if (producto == null)
            {
                return null;
            }

            // Devuelve el producto encontrado.
            return producto;
        }
    }
}