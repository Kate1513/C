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
    public partial class Menu_de_Acceso : Form
    {
        public Menu_de_Acceso()
        {
            InitializeComponent();
        }

        private void Menu_de_Acceso_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Clase_Pila_Click(object sender, EventArgs e)
        {
            {
                Pila___Etapa_3 Next_Form = new Pila___Etapa_3 ();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Btn_Clase_Cola_Click(object sender, EventArgs e)
        {
            {
                Cola___Etapa_3 Next_Form = new Cola___Etapa_3();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Btn_Clase_Lista_Click(object sender, EventArgs e)
        {
            {
                Lista___Etapa_3 Next_Form = new Lista___Etapa_3();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void Lbl_Seleccionar_Formulario_Click(object sender, EventArgs e)
        {

        }
    }
}
