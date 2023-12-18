using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal_v2;

namespace TrabajoFinal_v3
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        public FormCliente()
        {
            InitializeComponent();
            Actualizar();
        }
        private void Actualizar()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = RepositorioCliente.Instancia.ObtenerClientes();
        }
        private bool ValidarDatosAsiento()
        {
            if (string.IsNullOrEmpty(this.txtMail.Text))
            {
                MessageBox.Show("Debe ingresar el mail", "Atención");
                return false;
            }
            if (string.IsNullOrEmpty(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido", "Atención");
                return false;
            }
            if (!int.TryParse(this.numDNI.Text, out int DNI))
            {
                MessageBox.Show("Debe ingresar el concepto", "Atención");
                return false;
            }
            if (!int.TryParse(this.numTelefono.Text, out int Telefono))
            {
                MessageBox.Show("Debe ingresar el telefono", "Atención");
                return false;
            }
           
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarDatosAsiento())
            {
                Cliente cliente = new Cliente();
                cliente.Email = txtMail.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = (int)numDNI.Value;
                cliente.Telefono = (int)numTelefono.Value;
                bool agregado = RepositorioCliente.Instancia.AgregarCliente(cliente);
                if (agregado)
                {
                    MessageBox.Show("El cliente fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();

                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente. Verifique que el cliente no exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new FormVenta();
            Formulario.Show();
        }
    }
}

