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

namespace TrabajoFinal_v2
{
    public partial class FormAddStockHeladera : Form
    {
        // Definimos los repositorios para empleados, productos y ventas
       
        public FormAddStockHeladera()
        {
            InitializeComponent();
            
            Actualizar();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.FormPrincipal.Show();
        }

        //No prestar atencion a lo siguiente
        private void nudCodigo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.nudCant.Value = 1;
            this.nudCodigo.Value = 1000;
            this.nudPrecio.Value = 1;
            this.textBoxMarca.Text = "";
            this.textBoxProducto.Text = "";
            this.dtpFechaVencimiento.Value = DateTime.Now;
        }

        //Cada vez que carga el formulario se actualiza la tabla
        private void FormAddStockHeladera_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        // Método para actualizar la tabla de productos perecederos.
        private void Actualizar()
        {
            // Limpia la tabla y la actualiza con la lista de productos perecederos.
            dgvStockHeladera.DataSource = null;
            dgvStockHeladera.DataSource = RepositorioProducto.Instancia.ObtenerPerecederos();
            
            // Configura el color del texto en las filas para que sea visible ya que antes de poner esto no se veia
            foreach (DataGridViewRow row in dgvStockHeladera.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.Black; 
            }
        }

        //Validacion para que no se pueda ingresar numeros en el textbox
        private void textBoxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validacion para que no se pueda ingresar numeros en el textbox
        private void textBoxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Agrega un nuevo producto perecedero
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Crea un nuevo producto perecedero con los datos ingresados.
           
            ProductoPerecedero nuevoProductoP = new ProductoPerecedero();
            nuevoProductoP.Codigo = (int)nudCodigo.Value;
            nuevoProductoP.Marca = textBoxMarca.Text;
            nuevoProductoP.Nombre = textBoxProducto.Text;
            nuevoProductoP.Stock = (int)nudCant.Value;
            nuevoProductoP.PrecioUnitario = (decimal)nudPrecio.Value;
            nuevoProductoP.FechaVencimiento = dtpFechaVencimiento.Value; 
            // Intenta agregar el producto al repositorio de productos perecederos
            bool agregado = RepositorioProducto.Instancia.Agregar(nuevoProductoP);
            if (agregado)
            {
                MessageBox.Show("El Producto fue agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();

            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto. Verifique que el codigo no exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        //Elimina el producto seleccionado 
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en la tabla.
            if (dgvStockHeladera.SelectedRows.Count > 0)
            {
                // Obtiene el código del producto seleccionado
                DataGridViewRow selectedRow = dgvStockHeladera.SelectedRows[0];
                int codigoProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);

                // Intenta eliminar el producto del repositorio de productos perecederos.
                bool eliminado = RepositorioProducto.Instancia.Eliminar(codigoProducto);
                if (eliminado)
                {
                    MessageBox.Show("El producto fue eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Modifica el producto seleccionado 
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en la tabla
            if (dgvStockHeladera.SelectedRows.Count >0)
            {
                // Obtiene el código del producto seleccionado.
                DataGridViewRow selectedRow = dgvStockHeladera.SelectedRows[0];
                int codigoProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);

                // Crea un nuevo producto perecedero con los datos ingresados
                ProductoPerecedero productoModificado = new ProductoPerecedero();
                productoModificado.Codigo = (int)nudCodigo.Value;
                productoModificado.Marca = textBoxMarca.Text;
                productoModificado.Nombre = textBoxProducto.Text;
                productoModificado.Stock = (int)nudCant.Value;
                productoModificado.PrecioUnitario = (decimal)nudPrecio.Value;
                productoModificado.FechaVencimiento = dtpFechaVencimiento.Value;
                // Intenta modificar el producto en el repositorio de productos perecederos.
                bool modificado = RepositorioProducto.Instancia.Modificar(productoModificado);
                if (modificado)
                {
                    MessageBox.Show("El producto fue modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto. Verifique que el código sea igual al que desea cambiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
