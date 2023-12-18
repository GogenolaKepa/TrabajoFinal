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
    public partial class FormAddStockGondola : Form
    {
        // Definimos los repositorios para empleados, productos y ventas
       

        public FormAddStockGondola()
        {
            InitializeComponent();
            
            Actualizar();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.FormPrincipal.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.nudCant.Value = 1;
            this.nudCodigo.Value = 1;
            this.nudPrecio.Value = 1;
            this.nudPasillo.Value = 1;
            this.textBoxMarca.Text = "";
            this.textBoxProducto.Text = "";
        }

        //Cada vez que carga el formulario se actualiza la tabla
        private void FormAddStockGondola_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        

        // Método para actualizar la tabla de productos No perecederos
        private void Actualizar()
        {
            // Limpia la tabla y la actualiza con la lista de productos No perecederos.
            dgvStockGondola.DataSource = null;
            dgvStockGondola.DataSource = RepositorioProducto.Instancia.ObtenerNoPerecederos();
        }

        //Validacion para que no se pueda ingresar numeros en el textbox
        private void textBoxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <=64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Agrega un nuevo producto No perecedero
        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            int codigoProducto = (int)nudCodigo.Value;
            string marcaProducto = textBoxMarca.Text;
            string tipoProducto = textBoxProducto.Text;
            int stockProducto = (int)nudCant.Value;
            decimal precioProducto = (decimal)nudPrecio.Value;
            int pasilloProducto = (int)nudPasillo.Value;

            ProductoNoPerecedero nuevoProductoNP = new ProductoNoPerecedero();
            nuevoProductoNP.Codigo = codigoProducto;
            nuevoProductoNP.Marca = marcaProducto;
            nuevoProductoNP.Nombre = tipoProducto;
            nuevoProductoNP.Stock = stockProducto;
            nuevoProductoNP.PrecioUnitario = precioProducto;
            nuevoProductoNP.Pasillo = pasilloProducto;
            bool agregado = RepositorioProducto.Instancia.Agregar(nuevoProductoNP);

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
            if (dgvStockGondola.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStockGondola.SelectedRows[0];
                int codigoProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);
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
            if (dgvStockGondola.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStockGondola.SelectedRows[0];
                int codigoProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);


                
                string marcaProducto = textBoxMarca.Text;
                string tipoProducto = textBoxProducto.Text;
                int stockProducto = (int)nudCant.Value;
                decimal precioProducto = (decimal)nudPrecio.Value;
                int pasilloProducto = (int)nudPasillo.Value;

                ProductoNoPerecedero productoModificado = new ProductoNoPerecedero();
                productoModificado.Codigo = codigoProducto;
                productoModificado.Marca = marcaProducto;
                productoModificado.Nombre = tipoProducto;
                productoModificado.Stock = stockProducto;
                productoModificado.PrecioUnitario = precioProducto;
                productoModificado.Pasillo = pasilloProducto;


                // Realiza la modificación del producto en la lista
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
