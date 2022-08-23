using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etapa_3___Katerine_Ipuz_Lopez
{
    public partial class Formulario_De_Ingreso : Form
    {
        public Formulario_De_Ingreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl_Etapa_3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Elaborado_Por_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Name_Click(object sender, EventArgs e)
        {

        }

       
        private void Txt_Clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formulario_De_Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Txt_Clave.Text != "123") 
            {
                MessageBox.Show("Contraseña incorrecta, digitela nuevamente");
                Txt_Clave.Clear();
            }
            else
            {
                Menu_de_Acceso Next_Form = new Menu_de_Acceso();
                Next_Form.Show();
                this.Hide();
            }
        }
    }
}
