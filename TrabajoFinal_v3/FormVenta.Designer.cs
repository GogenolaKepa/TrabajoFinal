
namespace TrabajoFinal_v2
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelVentaProducto = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbDescuento = new System.Windows.Forms.ComboBox();
            this.cmbItemDeVenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(992, 620);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 54);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(46, 289);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(179, 24);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Item de Venta";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.White;
            this.Cliente.Location = new System.Drawing.Point(822, 289);
            this.Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(101, 24);
            this.Cliente.TabIndex = 5;
            this.Cliente.Text = "Cliente";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(440, 289);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(127, 24);
            this.labelCantidad.TabIndex = 14;
            this.labelCantidad.Text = "Descuento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 620);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 54);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelVentaProducto
            // 
            this.labelVentaProducto.AutoSize = true;
            this.labelVentaProducto.Font = new System.Drawing.Font("MS Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentaProducto.ForeColor = System.Drawing.Color.White;
            this.labelVentaProducto.Location = new System.Drawing.Point(388, 85);
            this.labelVentaProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVentaProducto.Name = "labelVentaProducto";
            this.labelVentaProducto.Size = new System.Drawing.Size(433, 44);
            this.labelVentaProducto.TabIndex = 23;
            this.labelVentaProducto.Text = "VENTA DE PRODUCTOS";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(826, 325);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(288, 28);
            this.cmbCliente.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(826, 620);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 54);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // cmbDescuento
            // 
            this.cmbDescuento.FormattingEnabled = true;
            this.cmbDescuento.Location = new System.Drawing.Point(444, 325);
            this.cmbDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDescuento.Name = "cmbDescuento";
            this.cmbDescuento.Size = new System.Drawing.Size(288, 28);
            this.cmbDescuento.TabIndex = 63;
            // 
            // cmbItemDeVenta
            // 
            this.cmbItemDeVenta.FormattingEnabled = true;
            this.cmbItemDeVenta.Location = new System.Drawing.Point(51, 325);
            this.cmbItemDeVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbItemDeVenta.Name = "cmbItemDeVenta";
            this.cmbItemDeVenta.Size = new System.Drawing.Size(288, 28);
            this.cmbItemDeVenta.TabIndex = 64;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cmbItemDeVenta);
            this.Controls.Add(this.cmbDescuento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.labelVentaProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVenta";
            this.Text = "Almacen De Beto";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelVentaProducto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbDescuento;
        private System.Windows.Forms.ComboBox cmbItemDeVenta;
    }
}