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
    public partial class FormDescuentos : Form
    {
        public FormDescuentos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var descuento = new Descuento();
            descuento.Fecha = new DateTime(2024, 2, 10);
            descuento.Porcentaje = 50;
            descuento.Codigo = 1;
            var descuento2 = new Descuento();
            descuento2.Fecha = (DateTime.Now);
            descuento2.Porcentaje = 0;
            descuento2.Codigo = 2;
            RepositorioDescuento.Instancia.AgregarDescuento(descuento);
            RepositorioDescuento.Instancia.AgregarDescuento(descuento2);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new FormVenta();
            Formulario.Show();
        }
    }
}
