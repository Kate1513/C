using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etapa_4___Katerine_Ipuz_Lopez2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
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
                Menu_De_Acceso Next_Form = new Menu_De_Acceso();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Lbl_AB_Click(object sender, EventArgs e)
        {

        }
    }
}
