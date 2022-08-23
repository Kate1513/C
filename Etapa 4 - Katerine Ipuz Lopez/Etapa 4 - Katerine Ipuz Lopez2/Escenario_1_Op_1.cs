using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etapa_4___Katerine_Ipuz_Lopez2
{
    public partial class Escenario_1_Op_1 : Form
    {
        public Escenario_1_Op_1()
        {
            InitializeComponent();
        }

        Graphics Nodo_ArbolB;
        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nodo_ArbolB = CreateGraphics();
            Pen LineaAB = new Pen(Color.Black, 2);
            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue , 320, 30, 40, 40);
            Nodo_ArbolB.DrawString("50", Font, Brushes.White, 333, 43);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue , 220, 90, 35, 35);
            Nodo_ArbolB.DrawString("40", Font, Brushes.White, 228, 100);
            Nodo_ArbolB.DrawLine(LineaAB, 321, 44, 240, 91);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 140, 160, 35, 35);
            Nodo_ArbolB.DrawString("30", Font, Brushes.White, 148, 170);
            Nodo_ArbolB.DrawLine(LineaAB, 155, 161, 220, 105);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 80, 240, 35, 35);
            Nodo_ArbolB.DrawString("25", Font, Brushes.White, 89, 249);
            Nodo_ArbolB.DrawLine(LineaAB, 96, 240, 140, 178);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 190, 239, 35, 35);
            Nodo_ArbolB.DrawString("35", Font, Brushes.White, 200, 249);
            Nodo_ArbolB.DrawLine(LineaAB, 206, 240, 174, 175);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 300, 160, 35, 35);
            Nodo_ArbolB.DrawString("45", Font, Brushes.White, 308, 170);
            Nodo_ArbolB.DrawLine(LineaAB, 315, 160, 254, 105);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 240, 239, 35, 35);
            Nodo_ArbolB.DrawString("42", Font, Brushes.White, 250, 249);
            Nodo_ArbolB.DrawLine(LineaAB, 255, 239, 301, 175);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 420, 90, 35, 35);
            Nodo_ArbolB.DrawString("60", Font, Brushes.White, 430, 100);
            Nodo_ArbolB.DrawLine(LineaAB, 358, 44, 435, 90);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 355, 160, 35, 35);
            Nodo_ArbolB.DrawString("55", Font, Brushes.White, 365, 170);
            Nodo_ArbolB.DrawLine(LineaAB, 372, 160, 421, 105);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 485, 160, 35, 35);
            Nodo_ArbolB.DrawString("70", Font, Brushes.White, 495, 170);
            Nodo_ArbolB.DrawLine(LineaAB, 503, 161, 454, 105);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 420, 240, 35, 35);
            Nodo_ArbolB.DrawString("65", Font, Brushes.White, 428, 249);
            Nodo_ArbolB.DrawLine(LineaAB, 436, 240, 486, 174);

            Nodo_ArbolB.FillEllipse(Brushes.CadetBlue, 550, 240, 35, 35);
            Nodo_ArbolB.DrawString("75", Font, Brushes.White, 560, 249);
            Nodo_ArbolB.DrawLine(LineaAB, 565, 240, 519, 174);

        }

       
        private void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graphics Preorden_Arbol_1;
            Preorden_Arbol_1 = CreateGraphics();
            Preorden_Arbol_1.DrawString("Preorden:  ", Font, Brushes.BlueViolet , 170, 320 ) ;

            Preorden_Arbol_1.DrawString("50, ", Font, Brushes.Black, 240, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("40, ", Font, Brushes.Black, 260, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("30, ", Font, Brushes.Black, 280, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("25, ", Font, Brushes.Black, 300, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("35, ", Font, Brushes.Black, 320, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("45, ", Font, Brushes.Black, 340, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("42, ", Font, Brushes.Black, 360, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("60, ", Font, Brushes.Black, 380, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("55, ", Font, Brushes.Black, 400, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("70, ", Font, Brushes.Black, 420, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("65, ", Font, Brushes.Black, 440, 320);
            Thread.Sleep(500);
            Preorden_Arbol_1.DrawString("75. ", Font, Brushes.Black, 460, 320);
            Thread.Sleep(500);

        }

        private void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graphics Inorden_Arbol_1;
            Inorden_Arbol_1 = CreateGraphics();
            Inorden_Arbol_1.DrawString("Inorden:  ", Font, Brushes.Red, 175, 350);

            Inorden_Arbol_1.DrawString("25, ", Font, Brushes.Black, 240, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("30, ", Font, Brushes.Black, 260, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("35, ", Font, Brushes.Black, 280, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("40, ", Font, Brushes.Black, 300, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("42, ", Font, Brushes.Black, 320, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("45, ", Font, Brushes.Black, 340, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("50, ", Font, Brushes.Black, 360, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("55, ", Font, Brushes.Black, 380, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("60, ", Font, Brushes.Black, 400, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("65, ", Font, Brushes.Black, 420, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("70, ", Font, Brushes.Black, 440, 350);
            Thread.Sleep(500);
            Inorden_Arbol_1.DrawString("75. ", Font, Brushes.Black, 460, 350);
            Thread.Sleep(500);

        }

        private void postordenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graphics PostOrden_Arbol_1;
            PostOrden_Arbol_1 = CreateGraphics();
            PostOrden_Arbol_1.DrawString("Postorden:  ", Font, Brushes.Green, 170, 380);

            PostOrden_Arbol_1.DrawString("25, ", Font, Brushes.Black, 240, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("35, ", Font, Brushes.Black, 260, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("30, ", Font, Brushes.Black, 280, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("42, ", Font, Brushes.Black, 300, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("45, ", Font, Brushes.Black, 320, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("40, ", Font, Brushes.Black, 340, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("55, ", Font, Brushes.Black, 360, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("65, ", Font, Brushes.Black, 380, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("75, ", Font, Brushes.Black, 400, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("70, ", Font, Brushes.Black, 420, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("60, ", Font, Brushes.Black, 440, 380);
            Thread.Sleep(500);
            PostOrden_Arbol_1.DrawString("50. ", Font, Brushes.Black, 460, 380);
            Thread.Sleep(500);

        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Menu_De_Acceso Next_Form = new Menu_De_Acceso();
                Next_Form.Show();
                this.Hide();
            }
        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
