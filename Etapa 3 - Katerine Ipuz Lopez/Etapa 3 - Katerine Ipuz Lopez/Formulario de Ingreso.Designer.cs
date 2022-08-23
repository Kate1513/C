namespace Etapa_3___Katerine_Ipuz_Lopez
{
    partial class Formulario_De_Ingreso
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
            this.Lbl_Elaborado_Por = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_Etapa_3 = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Elaborado_Por
            // 
            this.Lbl_Elaborado_Por.AutoSize = true;
            this.Lbl_Elaborado_Por.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Elaborado_Por.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Lbl_Elaborado_Por.Location = new System.Drawing.Point(159, 162);
            this.Lbl_Elaborado_Por.Name = "Lbl_Elaborado_Por";
            this.Lbl_Elaborado_Por.Size = new System.Drawing.Size(88, 15);
            this.Lbl_Elaborado_Por.TabIndex = 0;
            this.Lbl_Elaborado_Por.Text = "Elaborado por:";
            this.Lbl_Elaborado_Por.Click += new System.EventHandler(this.Lbl_Elaborado_Por_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Lbl_Name.Location = new System.Drawing.Point(159, 177);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(153, 16);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Anyi Katerine Ipuz Lopez";
            this.Lbl_Name.Click += new System.EventHandler(this.Lbl_Name_Click);
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(58, 80);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(130, 16);
            this.Lbl_Contraseña.TabIndex = 2;
            this.Lbl_Contraseña.Text = "Ingrese la Contraseña:";
            this.Lbl_Contraseña.Click += new System.EventHandler(this.Lbl_Contraseña_Click);
            // 
            // Lbl_Etapa_3
            // 
            this.Lbl_Etapa_3.AutoSize = true;
            this.Lbl_Etapa_3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Etapa_3.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Etapa_3.Location = new System.Drawing.Point(52, 9);
            this.Lbl_Etapa_3.Name = "Lbl_Etapa_3";
            this.Lbl_Etapa_3.Size = new System.Drawing.Size(213, 44);
            this.Lbl_Etapa_3.TabIndex = 3;
            this.Lbl_Etapa_3.Text = "Componente Practico \r\nEtapa 3\r\n";
            this.Lbl_Etapa_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Etapa_3.Click += new System.EventHandler(this.Lbl_Etapa_3_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(117, 114);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 31);
            this.Btn_Aceptar.TabIndex = 4;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(194, 78);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(68, 20);
            this.Txt_Clave.TabIndex = 5;
            this.Txt_Clave.TextChanged += new System.EventHandler(this.Txt_Clave_TextChanged);
            // 
            // Formulario_De_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(324, 215);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_Etapa_3);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_Elaborado_Por);
            this.Name = "Formulario_De_Ingreso";
            this.Text = "Formulario de Ingreso";
            this.Load += new System.EventHandler(this.Formulario_De_Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Elaborado_Por;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.Label Lbl_Etapa_3;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.TextBox Txt_Clave;
    }
}