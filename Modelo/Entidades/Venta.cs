using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        private List<ItemVenta> itemVentas;
        private Cliente cliente;
        private Descuento descuento;
        private Empleado empleado;
        //private List<Producto> productos;
        private decimal precioFinal;

        public List<ItemVenta> ItemVentas { get { return itemVentas; } set { itemVentas = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public Descuento Descuento { get { return descuento; } set { descuento = value; } }
        public Empleado Empleado { get { return empleado; } set { empleado = value; } }
       // public List<Producto> Productos { get { return productos; } set { productos = value; } }
        public decimal PrecioFinal { get { return precioFinal; } set { precioFinal = value; } }//{ get => itemVenta.PrecioTotal - ((itemVenta.PrecioTotal * descuento.Porcentaje / 100)); }
        

        public Venta()
        {
            itemVentas = new List<ItemVenta>();            
        }
        public List<Producto> ObtenerProductos()
        {
            return ItemVentas.Select(item => item.Producto).ToList();
        }
        public void AgregarProd(int cant,Producto producto)
        {
            ItemVenta itemVenta = new ItemVenta();
            itemVenta.Producto = producto;
            itemVenta.Cantidad = cant;
            itemVentas.Add(itemVenta);

        }
        public void CalcularPrecioTotal()
        {
            decimal precioTotal = 0;

            foreach (var itemVenta in itemVentas)
            {
                decimal precioItem = itemVenta.Producto.PrecioUnitario * itemVenta.Cantidad;

                if (descuento != null)
                {
                    decimal descuentoAplicado = precioItem * descuento.Porcentaje / 100;
                    precioItem -= descuentoAplicado;
                }

                precioTotal += precioItem;
            }

            // Actualizar el precioFinal de la venta
            precioFinal = precioTotal;
        }

    }

}
