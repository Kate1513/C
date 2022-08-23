namespace Etapa_3___Katerine_Ipuz_Lopez
{
    partial class Menu_de_Acceso
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
            this.Lbl_Seleccionar_Formulario = new System.Windows.Forms.Label();
            this.Btn_Clase_Pila = new System.Windows.Forms.Button();
            this.Btn_Clase_Cola = new System.Windows.Forms.Button();
            this.Btn_Clase_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Seleccionar_Formulario
            // 
            this.Lbl_Seleccionar_Formulario.AutoSize = true;
            this.Lbl_Seleccionar_Formulario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seleccionar_Formulario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbl_Seleccionar_Formulario.Location = new System.Drawing.Point(19, 19);
            this.Lbl_Seleccionar_Formulario.Name = "Lbl_Seleccionar_Formulario";
            this.Lbl_Seleccionar_Formulario.Size = new System.Drawing.Size(233, 52);
            this.Lbl_Seleccionar_Formulario.TabIndex = 0;
            this.Lbl_Seleccionar_Formulario.Text = "Seleccione el formulario \r\nque desea diligenciar.";
            this.Lbl_Seleccionar_Formulario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Seleccionar_Formulario.Click += new System.EventHandler(this.Lbl_Seleccionar_Formulario_Click);
            // 
            // Btn_Clase_Pila
            // 
            this.Btn_Clase_Pila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Clase_Pila.Location = new System.Drawing.Point(52, 84);
            this.Btn_Clase_Pila.Name = "Btn_Clase_Pila";
            this.Btn_Clase_Pila.Size = new System.Drawing.Size(156, 38);
            this.Btn_Clase_Pila.TabIndex = 1;
            this.Btn_Clase_Pila.Text = "Empresa \"Telecom\" (Pila)";
            this.Btn_Clase_Pila.UseVisualStyleBackColor = false;
            this.Btn_Clase_Pila.Click += new System.EventHandler(this.Btn_Clase_Pila_Click);
            // 
            // Btn_Clase_Cola
            // 
            this.Btn_Clase_Cola.BackColor = System.Drawing.Color.Silver;
            this.Btn_Clase_Cola.Location = new System.Drawing.Point(22, 140);
            this.Btn_Clase_Cola.Name = "Btn_Clase_Cola";
            this.Btn_Clase_Cola.Size = new System.Drawing.Size(217, 41);
            this.Btn_Clase_Cola.TabIndex = 2;
            this.Btn_Clase_Cola.Text = "Agencia \"Viajando por el mundo\" (Cola)";
            this.Btn_Clase_Cola.UseVisualStyleBackColor = false;
            this.Btn_Clase_Cola.Click += new System.EventHandler(this.Btn_Clase_Cola_Click);
            // 
            // Btn_Clase_Lista
            // 
            this.Btn_Clase_Lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Clase_Lista.Location = new System.Drawing.Point(36, 198);
            this.Btn_Clase_Lista.Name = "Btn_Clase_Lista";
            this.Btn_Clase_Lista.Size = new System.Drawing.Size(186, 39);
            this.Btn_Clase_Lista.TabIndex = 3;
            this.Btn_Clase_Lista.Text = "“Supermercado Carrefour” (Lista)";
            this.Btn_Clase_Lista.UseVisualStyleBackColor = false;
            this.Btn_Clase_Lista.Click += new System.EventHandler(this.Btn_Clase_Lista_Click);
            // 
            // Menu_de_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 268);
            this.Controls.Add(this.Btn_Clase_Lista);
            this.Controls.Add(this.Btn_Clase_Cola);
            this.Controls.Add(this.Btn_Clase_Pila);
            this.Controls.Add(this.Lbl_Seleccionar_Formulario);
            this.Name = "Menu_de_Acceso";
            this.Text = "Menu_de_Acceso";
            this.Load += new System.EventHandler(this.Menu_de_Acceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Seleccionar_Formulario;
        private System.Windows.Forms.Button Btn_Clase_Pila;
        private System.Windows.Forms.Button Btn_Clase_Cola;
        private System.Windows.Forms.Button Btn_Clase_Lista;
    }
}