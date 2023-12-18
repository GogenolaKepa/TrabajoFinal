
namespace TrabajoFinal_v3
{
    partial class FormAddStockGondola
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dgvStockGondola = new System.Windows.Forms.DataGridView();
            this.labelSimboloPeso = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPasillo = new System.Windows.Forms.Label();
            this.nudPasillo = new System.Windows.Forms.NumericUpDown();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockGondola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasillo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(707, 403);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(81, 35);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "VOLVER";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // dgvStockGondola
            // 
            this.dgvStockGondola.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockGondola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockGondola.Location = new System.Drawing.Point(330, 28);
            this.dgvStockGondola.Name = "dgvStockGondola";
            this.dgvStockGondola.Size = new System.Drawing.Size(458, 367);
            this.dgvStockGondola.TabIndex = 56;
            // 
            // labelSimboloPeso
            // 
            this.labelSimboloPeso.AutoSize = true;
            this.labelSimboloPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimboloPeso.ForeColor = System.Drawing.Color.White;
            this.labelSimboloPeso.Location = new System.Drawing.Point(34, 311);
            this.labelSimboloPeso.Name = "labelSimboloPeso";
            this.labelSimboloPeso.Size = new System.Drawing.Size(14, 16);
            this.labelSimboloPeso.TabIndex = 55;
            this.labelSimboloPeso.Text = "$";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(417, 403);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(81, 35);
            this.buttonModificar.TabIndex = 54;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(330, 403);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(81, 35);
            this.buttonAgregar.TabIndex = 53;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(54, 311);
            this.nudPrecio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(193, 20);
            this.nudPrecio.TabIndex = 51;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(54, 249);
            this.nudCant.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(193, 20);
            this.nudCant.TabIndex = 50;
            this.nudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(54, 47);
            this.nudCodigo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCodigo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(193, 20);
            this.nudCodigo.TabIndex = 49;
            this.nudCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(51, 230);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(79, 16);
            this.labelCantidad.TabIndex = 48;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(54, 182);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ShortcutsEnabled = false;
            this.textBoxMarca.Size = new System.Drawing.Size(193, 20);
            this.textBoxMarca.TabIndex = 47;
            this.textBoxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMarca_KeyPress);
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(54, 113);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.ShortcutsEnabled = false;
            this.textBoxProducto.Size = new System.Drawing.Size(193, 20);
            this.textBoxProducto.TabIndex = 46;
            this.textBoxProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProducto_KeyPress);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(51, 94);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(79, 16);
            this.labelProducto.TabIndex = 45;
            this.labelProducto.Text = "Producto";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(51, 292);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(61, 16);
            this.labelPrecio.TabIndex = 43;
            this.labelPrecio.Text = "Precio";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(51, 28);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(61, 16);
            this.labelCodigo.TabIndex = 42;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(51, 162);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(52, 16);
            this.labelMarca.TabIndex = 41;
            this.labelMarca.Text = "Marca";
            // 
            // labelPasillo
            // 
            this.labelPasillo.AutoSize = true;
            this.labelPasillo.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasillo.ForeColor = System.Drawing.Color.White;
            this.labelPasillo.Location = new System.Drawing.Point(51, 361);
            this.labelPasillo.Name = "labelPasillo";
            this.labelPasillo.Size = new System.Drawing.Size(70, 16);
            this.labelPasillo.TabIndex = 57;
            this.labelPasillo.Text = "Pasillo";
            // 
            // nudPasillo
            // 
            this.nudPasillo.Location = new System.Drawing.Point(54, 380);
            this.nudPasillo.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudPasillo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasillo.Name = "nudPasillo";
            this.nudPasillo.Size = new System.Drawing.Size(193, 20);
            this.nudPasillo.TabIndex = 58;
            this.nudPasillo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(504, 403);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(81, 35);
            this.buttonEliminar.TabIndex = 59;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(620, 403);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(81, 35);
            this.buttonLimpiar.TabIndex = 60;
            this.buttonLimpiar.Text = "LIMPIAR";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // FormAddStockGondola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.nudPasillo);
            this.Controls.Add(this.labelPasillo);
            this.Controls.Add(this.dgvStockGondola);
            this.Controls.Add(this.labelSimboloPeso);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxProducto);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.buttonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddStockGondola";
            this.Text = "Almacen De Beto";
            this.Load += new System.EventHandler(this.FormAddStockGondola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockGondola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dgvStockGondola;
        private System.Windows.Forms.Label labelSimboloPeso;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelPasillo;
        private System.Windows.Forms.NumericUpDown nudPasillo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}