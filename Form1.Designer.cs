namespace formulario
{
    partial class Formulario
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbEstatura = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.rdBttHombre = new System.Windows.Forms.RadioButton();
            this.rdBttMujer = new System.Windows.Forms.RadioButton();
            this.bttBorrar = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(51, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(51, 85);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(57, 16);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(51, 129);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 16);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad";
            // 
            // lbEstatura
            // 
            this.lbEstatura.AutoSize = true;
            this.lbEstatura.Location = new System.Drawing.Point(51, 173);
            this.lbEstatura.Name = "lbEstatura";
            this.lbEstatura.Size = new System.Drawing.Size(56, 16);
            this.lbEstatura.TabIndex = 3;
            this.lbEstatura.Text = "Estatura";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(51, 217);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(61, 16);
            this.lbTelefono.TabIndex = 4;
            this.lbTelefono.Text = "Telefono";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(54, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(54, 104);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 22);
            this.tbApellido.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(54, 148);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 22);
            this.tbEdad.TabIndex = 7;
            // 
            // tbEstatura
            // 
            this.tbEstatura.Location = new System.Drawing.Point(54, 192);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(100, 22);
            this.tbEstatura.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(54, 236);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 22);
            this.tbTelefono.TabIndex = 9;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(51, 261);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(52, 16);
            this.lbGenero.TabIndex = 10;
            this.lbGenero.Text = "Genero";
            // 
            // rdBttHombre
            // 
            this.rdBttHombre.AllowDrop = true;
            this.rdBttHombre.AutoSize = true;
            this.rdBttHombre.Location = new System.Drawing.Point(54, 280);
            this.rdBttHombre.Name = "rdBttHombre";
            this.rdBttHombre.Size = new System.Drawing.Size(77, 20);
            this.rdBttHombre.TabIndex = 11;
            this.rdBttHombre.TabStop = true;
            this.rdBttHombre.Text = "Hombre";
            this.rdBttHombre.UseVisualStyleBackColor = true;
            this.rdBttHombre.CheckedChanged += new System.EventHandler(this.rdBttHombre_CheckedChanged);
            // 
            // rdBttMujer
            // 
            this.rdBttMujer.AutoSize = true;
            this.rdBttMujer.Location = new System.Drawing.Point(137, 280);
            this.rdBttMujer.Name = "rdBttMujer";
            this.rdBttMujer.Size = new System.Drawing.Size(61, 20);
            this.rdBttMujer.TabIndex = 12;
            this.rdBttMujer.TabStop = true;
            this.rdBttMujer.Text = "Mujer";
            this.rdBttMujer.UseVisualStyleBackColor = true;
            // 
            // bttBorrar
            // 
            this.bttBorrar.Location = new System.Drawing.Point(54, 326);
            this.bttBorrar.Name = "bttBorrar";
            this.bttBorrar.Size = new System.Drawing.Size(75, 23);
            this.bttBorrar.TabIndex = 13;
            this.bttBorrar.Text = "Borrar";
            this.bttBorrar.UseVisualStyleBackColor = true;
            this.bttBorrar.Click += new System.EventHandler(this.bttBorrar_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(135, 326);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 14;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 393);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.bttBorrar);
            this.Controls.Add(this.rdBttMujer);
            this.Controls.Add(this.rdBttHombre);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbEstatura);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbEstatura;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.RadioButton rdBttHombre;
        private System.Windows.Forms.RadioButton rdBttMujer;
        private System.Windows.Forms.Button bttBorrar;
        private System.Windows.Forms.Button bttGuardar;
    }
}

