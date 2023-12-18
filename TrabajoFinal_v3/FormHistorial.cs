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
    public partial class FormHistorial : Form
    {
        // Definimos los repositorios para empleados, productos y ventas
       
        public FormHistorial()
        {
            InitializeComponent();
            
            Actualizar();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new FormVenta();
            Formulario.Show();
        }

        //Ignorar
        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Cada vez que carga el formulario se actualiza la tabla
        private void FormHistorial_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        // Método para actualizar la tabla de ventas
        private void Actualizar()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = RepositorioVenta.Instancia.ObtenerVentas();
        }      
    }
}
