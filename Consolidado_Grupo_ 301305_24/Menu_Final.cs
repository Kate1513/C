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
    public partial class Menu_Final : Form
    {
        public Menu_Final()
        {
            InitializeComponent();
        }

        private void Btn_Et_2_Click(object sender, EventArgs e)
        {
            Etapa_2___Katerine_Ipuz_Lopez.Simulador_AwVillas Etapa_2 = new Etapa_2___Katerine_Ipuz_Lopez.Simulador_AwVillas();
            Etapa_2.Show();
        }

        private void Btn_Et_3_Click(object sender, EventArgs e)
        {
            Etapa_3___Katerine_Ipuz_Lopez.Menu_de_Acceso Etapa_3 = new Etapa_3___Katerine_Ipuz_Lopez.Menu_de_Acceso();
            Etapa_3.Show();
        }

        private void Btn_Et_4_Click(object sender, EventArgs e)
        {
            Etapa_4___Katerine_Ipuz_Lopez2.Menu_De_Acceso Etapa_4 = new Etapa_4___Katerine_Ipuz_Lopez2.Menu_De_Acceso();
            Etapa_4.Show();
        }

        private void Btn_SalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
