namespace Consolidado_Grupo__301305_24
{
    partial class Ingreso
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
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_Etapa_3 = new System.Windows.Forms.Label();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Elaborado_Por = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(167, 96);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(68, 20);
            this.Txt_Clave.TabIndex = 17;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(90, 132);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 31);
            this.Btn_Aceptar.TabIndex = 16;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_Etapa_3
            // 
            this.Lbl_Etapa_3.AutoSize = true;
            this.Lbl_Etapa_3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Etapa_3.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Etapa_3.Location = new System.Drawing.Point(63, 19);
            this.Lbl_Etapa_3.Name = "Lbl_Etapa_3";
            this.Lbl_Etapa_3.Size = new System.Drawing.Size(157, 66);
            this.Lbl_Etapa_3.TabIndex = 15;
            this.Lbl_Etapa_3.Text = "Evaluacion Final\r\nSocializacion\r\n\r\n";
            this.Lbl_Etapa_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(31, 98);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(130, 16);
            this.Lbl_Contraseña.TabIndex = 14;
            this.Lbl_Contraseña.Text = "Ingrese la Contraseña:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Lbl_Name.Location = new System.Drawing.Point(132, 195);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(153, 16);
            this.Lbl_Name.TabIndex = 13;
            this.Lbl_Name.Text = "Anyi Katerine Ipuz Lopez";
            // 
            // Lbl_Elaborado_Por
            // 
            this.Lbl_Elaborado_Por.AutoSize = true;
            this.Lbl_Elaborado_Por.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Elaborado_Por.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Lbl_Elaborado_Por.Location = new System.Drawing.Point(132, 180);
            this.Lbl_Elaborado_Por.Name = "Lbl_Elaborado_Por";
            this.Lbl_Elaborado_Por.Size = new System.Drawing.Size(88, 15);
            this.Lbl_Elaborado_Por.TabIndex = 12;
            this.Lbl_Elaborado_Por.Text = "Elaborado por:";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 241);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_Etapa_3);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_Elaborado_Por);
            this.Name = "Ingreso";
            this.Text = "Evaluacion Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_Etapa_3;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Elaborado_Por;
    }
}

