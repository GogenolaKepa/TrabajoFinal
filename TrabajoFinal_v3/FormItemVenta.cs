using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal_v2;

namespace TrabajoFinal_v3
{
    public partial class FormItemVenta : Form
    {
        
        private List<Producto> listaProductos;      
        private List<ItemVenta> listaItemsVenta;
        private ItemVenta itemVentaActual;
        private List<(Producto Producto, int Cantidad)> listaTemporalProductos;
        private decimal PrecioTotal = 0;

        public FormItemVenta()
        {
            InitializeComponent();
            listaTemporalProductos = new List<(Producto, int)>();
            listaProductos = new List<Producto>();
            listaItemsVenta = new List<ItemVenta>();           
            Actualizar();
            ApellidosCmbBox();
        }
        
        private void ApellidosCmbBox()
        {
            cmbEmpleados.DataSource = RepositorioEmpleado.Instancia.ObtenerEmpleados();
            cmbEmpleados.DisplayMember = "Apellido";
            cmbProductos.DataSource = RepositorioProducto.Instancia.ObtenerProductos();
            cmbProductos.DisplayMember = "Nombre";
            cmbCliente.DataSource = RepositorioCliente.Instancia.ObtenerClientes();
            cmbCliente.DisplayMember = "Apellido";
            cmbDescuento.DataSource = RepositorioDescuento.Instancia.ObtenerDescuentos();
            cmbDescuento.DisplayMember = "Porcentaje";

        }
        private void Actualizar()
        {
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = listaTemporalProductos;
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = RepositorioVenta.Instancia.ObtenerVentas();

        }
        private bool ValidacionListaTemporal(Producto producto,List<Producto> listaP)
        {
            var productoExistente = listaP.FirstOrDefault(p => producto.Codigo == p.Codigo);
            if (productoExistente != null)
            {
                return true;
            }
            return false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = cmbProductos.SelectedItem as Producto;
            if (productoSeleccionado == null || productoSeleccionado.Stock < numCantidad.Value)
            {
                MessageBox.Show("No hay suficiente stock para este producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidadDeseada = (int)numCantidad.Value;
            var productoExistente = ValidacionListaTemporal(productoSeleccionado, listaProductos);
            if (productoExistente)
            {
                MessageBox.Show("El producto ya fue agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            listaTemporalProductos.Add((productoSeleccionado, cantidadDeseada));
            listaProductos.Add(productoSeleccionado);
            decimal precio = productoSeleccionado.PrecioUnitario * cantidadDeseada;
            PrecioTotal += precio;
            

            //Averiguar como hacer para que un label se actualize con el precio cada vez q agregas un producto
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = listaTemporalProductos.Select(item => new { Producto = item.Producto.Nombre, Cantidad = item.Cantidad }).ToList();
            MessageBox.Show($"El precio total actualmente es de {PrecioTotal}");
           
        }


        private void FormItemVenta_Load(object sender, EventArgs e)
        {

            cmbEmpleados.DisplayMember = "Apellido";

            Actualizar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.FormPrincipal.Show();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.SelectedRows.Count > 0)
            {
                var seleccion = dgvListaProductos.SelectedRows[0].DataBoundItem as dynamic;

                var productoSeleccionado = seleccion.Producto;
                var cantidadSeleccionada = seleccion.Cantidad;

                // Encuentra y elimina la tupla correspondiente en listaTemporalProductos
                var eliminar = listaTemporalProductos.FirstOrDefault(item => item.Producto.Nombre == productoSeleccionado && item.Cantidad == cantidadSeleccionada);

                if (eliminar != default((Producto, int)))
                {
                    listaTemporalProductos.Remove(eliminar);

                    MessageBox.Show("El producto fue eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();

                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = cmbEmpleados.SelectedItem as Empleado;
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            foreach (var (producto, cantidad) in listaTemporalProductos)
            {
                producto.ActualizarStock(cantidad);
                if (producto.Stock < 5)
                {
                    using (var client = new System.Net.Mail.SmtpClient())
                    {
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("trabajopoo123@gmail.com", "cdlp ibty kidi nyev");
                        using (var message = new MailMessage(
                            from: new MailAddress("trabajopoo123@gmail.com", "TrabajoPOO"),
                            to: new MailAddress("kratos2319t@gmail.com", "Its Kratoss")
                            ))
                        {

                            message.Subject = "Control de stock";
                            message.Body = $"Poco stock del producto {producto.Nombre}, {producto.Marca}.Quedan {producto.Stock} unidades";

                            client.Send(message);
                        }
                    }
                }
            }
            var clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
            var descuentoSeleccionado = cmbDescuento.SelectedItem as Descuento;
            Venta nuevaVenta = new Venta();
            nuevaVenta.Cliente = clienteSeleccionado;
            nuevaVenta.Descuento = descuentoSeleccionado;
            nuevaVenta.Empleado = empleadoSeleccionado;


            //Agrega los productos a la venta
            foreach (var (producto, cantidad) in listaTemporalProductos)
            {
                nuevaVenta.AgregarProd(cantidad, producto);
            }
            nuevaVenta.CalcularPrecioTotal();
            PrecioTotal = nuevaVenta.PrecioFinal;
            listaTemporalProductos.Clear();
            RepositorioVenta.Instancia.Agregar(nuevaVenta);
            MessageBox.Show($"La venta se realizo correcatemnte el precio es de ${PrecioTotal}");

            Actualizar();

        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int rowIndex = dgvVentas.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < RepositorioVenta.Instancia.ObtenerVentas().Count)
                {
                    var ventaSeleccionada = RepositorioVenta.Instancia.ObtenerVentas()[rowIndex];

                    dgvListaProductos.DataSource = null;
                    dgvListaProductos.DataSource = ventaSeleccionada.ItemVentas.Select(item => new
                    {
                        Producto = item.Producto.Nombre,
                        Cantidad = item.Cantidad
                    }).ToList();
                }
            }
        }
    }
}
