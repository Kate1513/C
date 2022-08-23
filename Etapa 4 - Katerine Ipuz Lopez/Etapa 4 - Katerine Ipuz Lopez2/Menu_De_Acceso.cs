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
    public partial class Menu_De_Acceso : Form
    {
        public Menu_De_Acceso()
        {
            InitializeComponent();
        }

        private void Lbl_Seleccionar_Escenario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Opcion_1_Click(object sender, EventArgs e)
        {
            {
                Escenario_1_Op_1 Next_Form = new Escenario_1_Op_1();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Btn_Opcion_2_Click(object sender, EventArgs e)
        {
            {
                Escenario_2_Op_2 Next_Form = new Escenario_2_Op_2();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
