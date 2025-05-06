namespace prySalvarezzaConexionBDD
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.dgvManejo = new System.Windows.Forms.DataGridView();
            this.mrcBuscar = new System.Windows.Forms.GroupBox();
            this.mrcAMEProductos = new System.Windows.Forms.GroupBox();
            this.CmbCategorias = new System.Windows.Forms.ComboBox();
            this.LblCategorías = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.NumStock = new System.Windows.Forms.NumericUpDown();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.LblDescripción = new System.Windows.Forms.Label();
            this.TxtDescripción = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.NumCodigo = new System.Windows.Forms.NumericUpDown();
            this.LblCódigo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).BeginInit();
            this.mrcAMEProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManejo
            // 
            this.dgvManejo.AllowUserToAddRows = false;
            this.dgvManejo.AllowUserToDeleteRows = false;
            this.dgvManejo.AllowUserToResizeColumns = false;
            this.dgvManejo.AllowUserToResizeRows = false;
            this.dgvManejo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvManejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManejo.Location = new System.Drawing.Point(216, 62);
            this.dgvManejo.MultiSelect = false;
            this.dgvManejo.Name = "dgvManejo";
            this.dgvManejo.ReadOnly = true;
            this.dgvManejo.RowHeadersVisible = false;
            this.dgvManejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManejo.Size = new System.Drawing.Size(569, 372);
            this.dgvManejo.TabIndex = 5;
            // 
            // mrcBuscar
            // 
            this.mrcBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcBuscar.Location = new System.Drawing.Point(215, 8);
            this.mrcBuscar.Name = "mrcBuscar";
            this.mrcBuscar.Size = new System.Drawing.Size(570, 47);
            this.mrcBuscar.TabIndex = 4;
            this.mrcBuscar.TabStop = false;
            this.mrcBuscar.Text = "Buscar producto";
            // 
            // mrcAMEProductos
            // 
            this.mrcAMEProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mrcAMEProductos.Controls.Add(this.CmbCategorias);
            this.mrcAMEProductos.Controls.Add(this.LblCategorías);
            this.mrcAMEProductos.Controls.Add(this.lblStock);
            this.mrcAMEProductos.Controls.Add(this.NumStock);
            this.mrcAMEProductos.Controls.Add(this.NumPrecio);
            this.mrcAMEProductos.Controls.Add(this.lblPrecio);
            this.mrcAMEProductos.Controls.Add(this.LblDescripción);
            this.mrcAMEProductos.Controls.Add(this.TxtDescripción);
            this.mrcAMEProductos.Controls.Add(this.LblNombre);
            this.mrcAMEProductos.Controls.Add(this.TxtNombre);
            this.mrcAMEProductos.Controls.Add(this.NumCodigo);
            this.mrcAMEProductos.Controls.Add(this.LblCódigo);
            this.mrcAMEProductos.Controls.Add(this.btnModificar);
            this.mrcAMEProductos.Controls.Add(this.btnEliminar);
            this.mrcAMEProductos.Controls.Add(this.btnDeshacer);
            this.mrcAMEProductos.Controls.Add(this.btnAgregar);
            this.mrcAMEProductos.Location = new System.Drawing.Point(9, 8);
            this.mrcAMEProductos.Name = "mrcAMEProductos";
            this.mrcAMEProductos.Size = new System.Drawing.Size(200, 426);
            this.mrcAMEProductos.TabIndex = 3;
            this.mrcAMEProductos.TabStop = false;
            this.mrcAMEProductos.Text = "Control Productos";
            // 
            // CmbCategorias
            // 
            this.CmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategorias.FormattingEnabled = true;
            this.CmbCategorias.Location = new System.Drawing.Point(8, 258);
            this.CmbCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCategorias.Name = "CmbCategorias";
            this.CmbCategorias.Size = new System.Drawing.Size(187, 21);
            this.CmbCategorias.TabIndex = 36;
            // 
            // LblCategorías
            // 
            this.LblCategorías.AutoSize = true;
            this.LblCategorías.Location = new System.Drawing.Point(5, 238);
            this.LblCategorías.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategorías.Name = "LblCategorías";
            this.LblCategorías.Size = new System.Drawing.Size(62, 13);
            this.LblCategorías.TabIndex = 37;
            this.LblCategorías.Text = "Categorías:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(5, 202);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock:";
            // 
            // NumStock
            // 
            this.NumStock.Location = new System.Drawing.Point(8, 217);
            this.NumStock.Margin = new System.Windows.Forms.Padding(2);
            this.NumStock.Name = "NumStock";
            this.NumStock.Size = new System.Drawing.Size(84, 20);
            this.NumStock.TabIndex = 34;
            // 
            // NumPrecio
            // 
            this.NumPrecio.Location = new System.Drawing.Point(8, 178);
            this.NumPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(84, 20);
            this.NumPrecio.TabIndex = 32;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(5, 163);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio:";
            // 
            // LblDescripción
            // 
            this.LblDescripción.AutoSize = true;
            this.LblDescripción.Location = new System.Drawing.Point(5, 97);
            this.LblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripción.Name = "LblDescripción";
            this.LblDescripción.Size = new System.Drawing.Size(66, 13);
            this.LblDescripción.TabIndex = 31;
            this.LblDescripción.Text = "Descripción:";
            // 
            // TxtDescripción
            // 
            this.TxtDescripción.Location = new System.Drawing.Point(8, 112);
            this.TxtDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripción.Name = "TxtDescripción";
            this.TxtDescripción.Size = new System.Drawing.Size(187, 20);
            this.TxtDescripción.TabIndex = 30;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(5, 56);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 29;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(8, 71);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtNombre.TabIndex = 28;
            // 
            // NumCodigo
            // 
            this.NumCodigo.Location = new System.Drawing.Point(8, 31);
            this.NumCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.NumCodigo.Name = "NumCodigo";
            this.NumCodigo.Size = new System.Drawing.Size(80, 20);
            this.NumCodigo.TabIndex = 27;
            // 
            // LblCódigo
            // 
            this.LblCódigo.AutoSize = true;
            this.LblCódigo.Location = new System.Drawing.Point(5, 16);
            this.LblCódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCódigo.Name = "LblCódigo";
            this.LblCódigo.Size = new System.Drawing.Size(43, 13);
            this.LblCódigo.TabIndex = 26;
            this.LblCódigo.Text = "Código:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(105, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(13, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeshacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.BackgroundImage")));
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.Location = new System.Drawing.Point(105, 343);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(79, 43);
            this.btnDeshacer.TabIndex = 1;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(13, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySalvarezzaConexionBDD.Properties.Resources.Fondo_carga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 446);
            this.Controls.Add(this.dgvManejo);
            this.Controls.Add(this.mrcBuscar);
            this.Controls.Add(this.mrcAMEProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarga";
            this.Text = "frmCarga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManejo)).EndInit();
            this.mrcAMEProductos.ResumeLayout(false);
            this.mrcAMEProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManejo;
        private System.Windows.Forms.GroupBox mrcBuscar;
        private System.Windows.Forms.GroupBox mrcAMEProductos;
        private System.Windows.Forms.ComboBox CmbCategorias;
        private System.Windows.Forms.Label LblCategorías;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown NumStock;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label LblDescripción;
        private System.Windows.Forms.TextBox TxtDescripción;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.NumericUpDown NumCodigo;
        private System.Windows.Forms.Label LblCódigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnAgregar;
    }
}