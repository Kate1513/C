using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etapa_2___Katerine_Ipuz_Lopez
{
    public partial class Ingreso_de_la_App : Form
    {
        public Ingreso_de_la_App()
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
                Simulador_AwVillas Next_Form = new Simulador_AwVillas();
                Next_Form.Show();
                this.Hide();
            }
        }
    }
}
