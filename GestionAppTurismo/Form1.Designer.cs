namespace GestionAppTurismo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lbSeleccion = new System.Windows.Forms.Label();
            this.comboBoxTablas = new System.Windows.Forms.ComboBox();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.txProvincia = new System.Windows.Forms.TextBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.txLocalidad = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNickname = new System.Windows.Forms.Label();
            this.txNickName = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.txRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(30, 34);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRol);
            this.groupBox1.Controls.Add(this.txRol);
            this.groupBox1.Controls.Add(this.txNickName);
            this.groupBox1.Controls.Add(this.lbNickname);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.lbSeleccion);
            this.groupBox1.Controls.Add(this.comboBoxTablas);
            this.groupBox1.Controls.Add(this.lbProvincia);
            this.groupBox1.Controls.Add(this.txProvincia);
            this.groupBox1.Controls.Add(this.lbLocalidad);
            this.groupBox1.Controls.Add(this.txLocalidad);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Location = new System.Drawing.Point(21, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(686, 93);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(605, 93);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lbSeleccion
            // 
            this.lbSeleccion.AutoSize = true;
            this.lbSeleccion.Location = new System.Drawing.Point(602, 17);
            this.lbSeleccion.Name = "lbSeleccion";
            this.lbSeleccion.Size = new System.Drawing.Size(34, 13);
            this.lbSeleccion.TabIndex = 8;
            this.lbSeleccion.Text = "Tabla";
            // 
            // comboBoxTablas
            // 
            this.comboBoxTablas.FormattingEnabled = true;
            this.comboBoxTablas.Location = new System.Drawing.Point(605, 34);
            this.comboBoxTablas.Name = "comboBoxTablas";
            this.comboBoxTablas.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTablas.TabIndex = 7;
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(309, 17);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(51, 13);
            this.lbProvincia.TabIndex = 6;
            this.lbProvincia.Text = "Provincia";
            // 
            // txProvincia
            // 
            this.txProvincia.Location = new System.Drawing.Point(312, 34);
            this.txProvincia.Name = "txProvincia";
            this.txProvincia.Size = new System.Drawing.Size(100, 20);
            this.txProvincia.TabIndex = 5;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(165, 17);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lbLocalidad.TabIndex = 4;
            this.lbLocalidad.Text = "Localidad";
            // 
            // txLocalidad
            // 
            this.txLocalidad.Location = new System.Drawing.Point(168, 34);
            this.txLocalidad.Name = "txLocalidad";
            this.txLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txLocalidad.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(27, 17);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(707, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(626, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(545, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(27, 71);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(55, 13);
            this.lbNickname.TabIndex = 11;
            this.lbNickname.Text = "Nickname";
            // 
            // txNickName
            // 
            this.txNickName.Location = new System.Drawing.Point(30, 93);
            this.txNickName.Name = "txNickName";
            this.txNickName.Size = new System.Drawing.Size(100, 20);
            this.txNickName.TabIndex = 12;
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Location = new System.Drawing.Point(165, 71);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(23, 13);
            this.lbRol.TabIndex = 14;
            this.lbRol.Text = "Rol";
            // 
            // txRol
            // 
            this.txRol.Location = new System.Drawing.Point(168, 93);
            this.txRol.Name = "txRol";
            this.txRol.Size = new System.Drawing.Size(100, 20);
            this.txRol.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.TextBox txLocalidad;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.TextBox txProvincia;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lbSeleccion;
        private System.Windows.Forms.ComboBox comboBoxTablas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.TextBox txNickName;
        private System.Windows.Forms.TextBox txRol;
    }
}

