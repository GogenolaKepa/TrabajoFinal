
namespace TrabajoFinal_v2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVenta = new System.Windows.Forms.Button();
            this.buttonAddStockHeladera = new System.Windows.Forms.Button();
            this.labelFrase = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelAlmacen = new System.Windows.Forms.Label();
            this.buttonAddStockGondola = new System.Windows.Forms.Button();
            this.btnItemVenta = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVenta
            // 
            this.buttonVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVenta.Location = new System.Drawing.Point(13, 24);
            this.buttonVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(150, 74);
            this.buttonVenta.TabIndex = 0;
            this.buttonVenta.Text = "VENTA DE PRODUCTOS";
            this.buttonVenta.UseVisualStyleBackColor = false;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // buttonAddStockHeladera
            // 
            this.buttonAddStockHeladera.Location = new System.Drawing.Point(36, 59);
            this.buttonAddStockHeladera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddStockHeladera.Name = "buttonAddStockHeladera";
            this.buttonAddStockHeladera.Size = new System.Drawing.Size(150, 74);
            this.buttonAddStockHeladera.TabIndex = 1;
            this.buttonAddStockHeladera.Text = "AGREGAR STOCK HELADERAS";
            this.buttonAddStockHeladera.UseVisualStyleBackColor = true;
            this.buttonAddStockHeladera.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFrase.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFrase.Location = new System.Drawing.Point(340, 192);
            this.labelFrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(614, 20);
            this.labelFrase.TabIndex = 5;
            this.labelFrase.Text = "\"El almacen de beto, un lugar al que siempre se vuelve\"";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(1060, 617);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(122, 57);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "CERRAR";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.Font = new System.Drawing.Font("MS Gothic", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlmacen.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAlmacen.Location = new System.Drawing.Point(279, 122);
            this.labelAlmacen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(686, 44);
            this.labelAlmacen.TabIndex = 8;
            this.labelAlmacen.Text = "BIENVENIDO AL ALMACEN DE BETO";
            // 
            // buttonAddStockGondola
            // 
            this.buttonAddStockGondola.Location = new System.Drawing.Point(36, 143);
            this.buttonAddStockGondola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddStockGondola.Name = "buttonAddStockGondola";
            this.buttonAddStockGondola.Size = new System.Drawing.Size(150, 74);
            this.buttonAddStockGondola.TabIndex = 9;
            this.buttonAddStockGondola.Text = "AGREGAR STOCK GONDOLAS";
            this.buttonAddStockGondola.UseVisualStyleBackColor = true;
            this.buttonAddStockGondola.Click += new System.EventHandler(this.buttonAddStockGondola_Click);
            // 
            // btnItemVenta
            // 
            this.btnItemVenta.Location = new System.Drawing.Point(35, 59);
            this.btnItemVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemVenta.Name = "btnItemVenta";
            this.btnItemVenta.Size = new System.Drawing.Size(148, 74);
            this.btnItemVenta.TabIndex = 10;
            this.btnItemVenta.Text = "REALIZAR VENTA";
            this.btnItemVenta.UseVisualStyleBackColor = true;
            this.btnItemVenta.Click += new System.EventHandler(this.btnItemVenta_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(36, 227);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(148, 74);
            this.btnEmpleados.TabIndex = 11;
            this.btnEmpleados.Text = "AGREGAR EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Location = new System.Drawing.Point(35, 227);
            this.btnDescuentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(150, 74);
            this.btnDescuentos.TabIndex = 68;
            this.btnDescuentos.Text = "DESCUENTOS";
            this.btnDescuentos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(33, 143);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(150, 74);
            this.btnClientes.TabIndex = 67;
            this.btnClientes.Text = "AGREGAR CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(15, 108);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(148, 74);
            this.btnHistorial.TabIndex = 66;
            this.btnHistorial.Text = "HISTORIAL DE VENTAS";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmpleados);
            this.groupBox1.Controls.Add(this.buttonAddStockHeladera);
            this.groupBox1.Controls.Add(this.buttonAddStockGondola);
            this.groupBox1.Location = new System.Drawing.Point(374, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 330);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANTENIMIENTO DEL ALMACEN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDescuentos);
            this.groupBox2.Controls.Add(this.btnItemVenta);
            this.groupBox2.Controls.Add(this.btnClientes);
            this.groupBox2.Location = new System.Drawing.Point(699, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 330);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VENTAS DEL ALMACEN";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.labelAlmacen);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelFrase);
            this.Controls.Add(this.buttonVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Almacen De Beto";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.Button buttonAddStockHeladera;
        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelAlmacen;
        private System.Windows.Forms.Button buttonAddStockGondola;
        private System.Windows.Forms.Button btnItemVenta;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

