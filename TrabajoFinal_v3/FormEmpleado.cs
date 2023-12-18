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
    public partial class FormEmpleado : Form
    {
        // Definimos los repositorios para empleados, productos, ventas y usamos el formVenta
        
        private FormVenta formVenta;
        public FormEmpleado()
        {
            InitializeComponent();
          
            Actualizar();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.FormPrincipal.Show();
        }

        // Método para actualizar la tabla de empleados
        private void Actualizar()
        {
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = RepositorioEmpleado.Instancia.Empleados.ToList();
        }

        //Validacion para que no se pueda ingresar numeros en el textbox
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validacion para que no se pueda ingresar numeros en el textbox
        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Agrega un nuevo empleado
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.Dni= (int)nudDni.Value;
            nuevoEmpleado.Nombre = textBoxNombre.Text;
            nuevoEmpleado.Apellido = textBoxApellido.Text;
            nuevoEmpleado.Edad = (int)nudEdad.Value;
            bool agregado = RepositorioEmpleado.Instancia.Agregar(nuevoEmpleado);
            if (agregado)
            {
                MessageBox.Show("El empleado fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
               
            }
            else
            {
                MessageBox.Show("No se pudo agregar el empleado. Verifique que el DNI no exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Elimina el empleado seleccionado 
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmpleado.SelectedRows[0];
                int dniEmpleado = Convert.ToInt32(selectedRow.Cells["Dni"].Value);
                bool eliminado = RepositorioEmpleado.Instancia.Eliminar(dniEmpleado);
                if (eliminado)
                {
                    MessageBox.Show("El empleado fue eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                   
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}