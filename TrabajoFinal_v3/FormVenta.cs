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
using TrabajoFinal_v3;

namespace TrabajoFinal_v2
{
    public partial class FormVenta : Form
    {
        // Definimos los repositorios para empleados, productos y ventas.
       
        public FormVenta()
        {
            InitializeComponent();
            ActualizarComboBox();
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.FormPrincipal.Show();
        }
        
        //Cierra el formulario Ventas y abre el formulario Historial
        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new FormHistorial();
            Formulario.Show();
        }

        
        

        private void FormVenta_Load(object sender, EventArgs e)
        {            
            ActualizarComboBox();
        }

        
        //Ignorar esto
        private void nudCodigo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.cmbCliente.SelectedItem = 0;
            this.cmbItemDeVenta.SelectedItem = 0;
            this.cmbDescuento.SelectedItem = 0;
        }

        // Actualiza el combobox con los apellidos
        public void ActualizarComboBox()
        {
            // Limpia el ComboBox antes de actualizarlo
            cmbCliente.DataSource = RepositorioCliente.Instancia.ObtenerClientes();
            cmbCliente.DisplayMember = "Apellido";

            cmbItemDeVenta.DataSource = RepositorioItemVenta.Instancia.ObtenerItemsVenta();
            cmbItemDeVenta.DisplayMember = "Codigo";

            cmbDescuento.DataSource = RepositorioDescuento.Instancia.ObtenerDescuentos();
            cmbDescuento.DisplayMember = "Porcentaje";

           
        }
        
        //Cambiarlo Entero
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var itemVentaSeleccionado = cmbItemDeVenta.SelectedItem as ItemVenta;
            var clienteSeleccionado = cmbCliente.SelectedItem as Cliente;
            var descuentoSeleccionado = cmbDescuento.SelectedItem as Descuento;
            DateTime fechaLimite = new DateTime(2024, 1, 10);
            DateTime fechaInicial = new DateTime(2023, 12, 1);
            DateTime comprobacion = descuentoSeleccionado.Fecha; 
            if (comprobacion > fechaLimite && fechaInicial < comprobacion)
            {
                MessageBox.Show("El descuento no funciona en esta fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
              
            Venta venta = new Venta();

            bool agregado = RepositorioVenta.Instancia.Agregar(venta);
            if (agregado)
            {
                MessageBox.Show("La venta fue agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo agregar la venta. Verifique que el codigo no exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();

            Form Formulario = new FormCliente();
            Formulario.Show();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new FormDescuentos();
            Formulario.Show();
        }
    }
}

