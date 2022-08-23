namespace Etapa_4___Katerine_Ipuz_Lopez2
{
    partial class Menu_De_Acceso
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
            this.Lbl_Seleccionar_Escenario = new System.Windows.Forms.Label();
            this.Btn_Opcion_1 = new System.Windows.Forms.Button();
            this.Btn_Opcion_2 = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Seleccionar_Escenario
            // 
            this.Lbl_Seleccionar_Escenario.AutoSize = true;
            this.Lbl_Seleccionar_Escenario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seleccionar_Escenario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lbl_Seleccionar_Escenario.Location = new System.Drawing.Point(24, 15);
            this.Lbl_Seleccionar_Escenario.Name = "Lbl_Seleccionar_Escenario";
            this.Lbl_Seleccionar_Escenario.Size = new System.Drawing.Size(214, 52);
            this.Lbl_Seleccionar_Escenario.TabIndex = 1;
            this.Lbl_Seleccionar_Escenario.Text = "Seleccione el escenario\r\nal que desea acceder.\r\n";
            this.Lbl_Seleccionar_Escenario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Seleccionar_Escenario.Click += new System.EventHandler(this.Lbl_Seleccionar_Escenario_Click);
            // 
            // Btn_Opcion_1
            // 
            this.Btn_Opcion_1.Location = new System.Drawing.Point(82, 89);
            this.Btn_Opcion_1.Name = "Btn_Opcion_1";
            this.Btn_Opcion_1.Size = new System.Drawing.Size(92, 33);
            this.Btn_Opcion_1.TabIndex = 2;
            this.Btn_Opcion_1.Text = "Escenario 1";
            this.Btn_Opcion_1.UseVisualStyleBackColor = true;
            this.Btn_Opcion_1.Click += new System.EventHandler(this.Btn_Opcion_1_Click);
            // 
            // Btn_Opcion_2
            // 
            this.Btn_Opcion_2.Location = new System.Drawing.Point(82, 146);
            this.Btn_Opcion_2.Name = "Btn_Opcion_2";
            this.Btn_Opcion_2.Size = new System.Drawing.Size(92, 33);
            this.Btn_Opcion_2.TabIndex = 3;
            this.Btn_Opcion_2.Text = "Escenario 2";
            this.Btn_Opcion_2.UseVisualStyleBackColor = true;
            this.Btn_Opcion_2.Click += new System.EventHandler(this.Btn_Opcion_2_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(82, 198);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(92, 28);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Menu_De_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 268);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Opcion_2);
            this.Controls.Add(this.Btn_Opcion_1);
            this.Controls.Add(this.Lbl_Seleccionar_Escenario);
            this.Name = "Menu_De_Acceso";
            this.Text = "Menu_De_Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Seleccionar_Escenario;
        private System.Windows.Forms.Button Btn_Opcion_1;
        private System.Windows.Forms.Button Btn_Opcion_2;
        private System.Windows.Forms.Button Btn_Salir;
    }
}