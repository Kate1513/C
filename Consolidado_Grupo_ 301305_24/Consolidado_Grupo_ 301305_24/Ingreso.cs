using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consolidado_Grupo__301305_24
{
    public partial class Ingreso : Form
    {
        public Ingreso()
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
                Menu_Final Next_Form = new Menu_Final();
                Next_Form.Show();
                this.Hide();
            }
        }
    }
}
