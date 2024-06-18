namespace GestionAppTurismo
{
    partial class MonumentoForm
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
            this.txNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbEstilo = new System.Windows.Forms.Label();
            this.txEstilo = new System.Windows.Forms.TextBox();
            this.lbVisitable = new System.Windows.Forms.Label();
            this.lbParking = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.txImagen = new System.Windows.Forms.TextBox();
            this.lbValoracion = new System.Windows.Forms.Label();
            this.txValoracion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.chkVisitable = new System.Windows.Forms.CheckBox();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(166, 59);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(110, 62);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(208, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(313, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(110, 106);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbEstilo
            // 
            this.lbEstilo.AutoSize = true;
            this.lbEstilo.Location = new System.Drawing.Point(110, 144);
            this.lbEstilo.Name = "lbEstilo";
            this.lbEstilo.Size = new System.Drawing.Size(35, 13);
            this.lbEstilo.TabIndex = 6;
            this.lbEstilo.Text = "Estilo:";
            // 
            // txEstilo
            // 
            this.txEstilo.Location = new System.Drawing.Point(166, 144);
            this.txEstilo.Name = "txEstilo";
            this.txEstilo.Size = new System.Drawing.Size(100, 20);
            this.txEstilo.TabIndex = 7;
            // 
            // lbVisitable
            // 
            this.lbVisitable.AutoSize = true;
            this.lbVisitable.Location = new System.Drawing.Point(110, 187);
            this.lbVisitable.Name = "lbVisitable";
            this.lbVisitable.Size = new System.Drawing.Size(49, 13);
            this.lbVisitable.TabIndex = 8;
            this.lbVisitable.Text = "Visitable:";
            // 
            // lbParking
            // 
            this.lbParking.AutoSize = true;
            this.lbParking.Location = new System.Drawing.Point(111, 221);
            this.lbParking.Name = "lbParking";
            this.lbParking.Size = new System.Drawing.Size(46, 13);
            this.lbParking.TabIndex = 10;
            this.lbParking.Text = "Parking:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(322, 62);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "Telefono:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(392, 59);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(100, 20);
            this.txTelefono.TabIndex = 13;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(322, 106);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(45, 13);
            this.lbImagen.TabIndex = 14;
            this.lbImagen.Text = "Imagen:";
            // 
            // txImagen
            // 
            this.txImagen.Location = new System.Drawing.Point(392, 103);
            this.txImagen.Name = "txImagen";
            this.txImagen.Size = new System.Drawing.Size(100, 20);
            this.txImagen.TabIndex = 15;
            // 
            // lbValoracion
            // 
            this.lbValoracion.AutoSize = true;
            this.lbValoracion.Location = new System.Drawing.Point(322, 144);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(60, 13);
            this.lbValoracion.TabIndex = 16;
            this.lbValoracion.Text = "Valoración:";
            // 
            // txValoracion
            // 
            this.txValoracion.Location = new System.Drawing.Point(392, 141);
            this.txValoracion.Name = "txValoracion";
            this.txValoracion.Size = new System.Drawing.Size(100, 20);
            this.txValoracion.TabIndex = 17;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(322, 187);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 18;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // txDescripcion
            // 
            this.txDescripcion.Location = new System.Drawing.Point(392, 184);
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txDescripcion.TabIndex = 19;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(322, 224);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lbLocalidad.TabIndex = 20;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // chkVisitable
            // 
            this.chkVisitable.AutoSize = true;
            this.chkVisitable.Location = new System.Drawing.Point(166, 187);
            this.chkVisitable.Name = "chkVisitable";
            this.chkVisitable.Size = new System.Drawing.Size(15, 14);
            this.chkVisitable.TabIndex = 22;
            this.chkVisitable.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(166, 221);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(15, 14);
            this.chkParking.TabIndex = 23;
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(392, 221);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(100, 21);
            this.cmbLocalidad.TabIndex = 24;
            // 
            // txFecha
            // 
            this.txFecha.Location = new System.Drawing.Point(166, 106);
            this.txFecha.Name = "txFecha";
            this.txFecha.Size = new System.Drawing.Size(100, 20);
            this.txFecha.TabIndex = 25;
            // 
            // MonumentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 369);
            this.Controls.Add(this.txFecha);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.chkParking);
            this.Controls.Add(this.chkVisitable);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.txValoracion);
            this.Controls.Add(this.lbValoracion);
            this.Controls.Add(this.txImagen);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbParking);
            this.Controls.Add(this.lbVisitable);
            this.Controls.Add(this.txEstilo);
            this.Controls.Add(this.lbEstilo);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txNombre);
            this.Name = "MonumentoForm";
            this.Text = "MonumentoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbEstilo;
        private System.Windows.Forms.TextBox txEstilo;
        private System.Windows.Forms.Label lbVisitable;
        private System.Windows.Forms.Label lbParking;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.TextBox txImagen;
        private System.Windows.Forms.Label lbValoracion;
        private System.Windows.Forms.TextBox txValoracion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.CheckBox chkVisitable;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.TextBox txFecha;
    }
}