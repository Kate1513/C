namespace Etapa_4___Katerine_Ipuz_Lopez2
{
    partial class Inicio
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_Autor = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_AB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(125, 193);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 12;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_Autor
            // 
            this.Lbl_Autor.AutoSize = true;
            this.Lbl_Autor.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Autor.Location = new System.Drawing.Point(159, 238);
            this.Lbl_Autor.Name = "Lbl_Autor";
            this.Lbl_Autor.Size = new System.Drawing.Size(159, 54);
            this.Lbl_Autor.TabIndex = 11;
            this.Lbl_Autor.Text = "Elaborado por:\r\nAnyi Katerine Ipuz Lopez\r\n\r\n";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(143, 144);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.Txt_Clave.TabIndex = 10;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(64, 104);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha.TabIndex = 9;
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(61, 140);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(60, 26);
            this.Lbl_Contraseña.TabIndex = 8;
            this.Lbl_Contraseña.Text = "Ingrese la \r\ncontraseña";
            this.Lbl_Contraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_AB
            // 
            this.Lbl_AB.AutoSize = true;
            this.Lbl_AB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AB.ForeColor = System.Drawing.Color.Green;
            this.Lbl_AB.Location = new System.Drawing.Point(70, 28);
            this.Lbl_AB.Name = "Lbl_AB";
            this.Lbl_AB.Size = new System.Drawing.Size(185, 50);
            this.Lbl_AB.TabIndex = 7;
            this.Lbl_AB.Text = "Saber Pro\r\nArboles Binarios\r\n";
            this.Lbl_AB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_AB.Click += new System.EventHandler(this.Lbl_AB_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 301);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_Autor);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Lbl_AB);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Btn_Aceptar;
        internal System.Windows.Forms.Label Lbl_Autor;
        internal System.Windows.Forms.TextBox Txt_Clave;
        internal System.Windows.Forms.DateTimePicker Dtp_Fecha;
        internal System.Windows.Forms.Label Lbl_Contraseña;
        internal System.Windows.Forms.Label Lbl_AB;
    }
}

