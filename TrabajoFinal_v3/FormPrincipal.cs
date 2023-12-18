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
using TrabajoFinal_v3;

namespace TrabajoFinal_v2
{
    public partial class FormPrincipal : Form
    {
        //Definimos los repositorios para empleados, productos y ventas.
        
        public FormPrincipal()
        {
            // Inicializa el formulario y los repositorios.
            InitializeComponent();         
            
            
        }

        //Muestra el formulario FormVenta.
        private void buttonVenta_Click(object sender, EventArgs e)
        {
            Program.FormPrincipal.Hide();
            FormVenta formVenta = new FormVenta();
            formVenta.Show();
        }
        
        //Muestra el formulario AddStockHeladera
        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            Program.FormPrincipal.Hide();
            Form Formulario = new FormAddStockHeladera();
            Formulario.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Muestra el formulario AddStockGondola
        private void buttonAddStockGondola_Click(object sender, EventArgs e)
        {
            Program.FormPrincipal.Hide();
            Form Formulario =new FormAddStockGondola();
            Formulario.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnItemVenta_Click(object sender, EventArgs e)
        {
            Program.FormPrincipal.Hide();
            Form Formulario = new FormItemVenta();
            Formulario.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Program.FormPrincipal.Hide();
            Form Formulario = new FormEmpleado();
            Formulario.Show();
        }
    }
}
