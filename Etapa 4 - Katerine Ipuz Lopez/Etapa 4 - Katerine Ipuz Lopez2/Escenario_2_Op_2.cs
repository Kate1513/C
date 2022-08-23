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
    public partial class Escenario_2_Op_2 : Form
    {
        public Escenario_2_Op_2()
        {
            InitializeComponent();
        }

        Graphics Nodo_ArbolB_2;
        private void graficaArbolBinario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Nodo_ArbolB_2 = CreateGraphics();
            Pen LineaAB = new Pen(Color.Black, 2);
            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 320, 30, 40, 40);
            Nodo_ArbolB_2.DrawString("36", Font, Brushes.White, 333, 43);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 220, 90, 35, 35);
            Nodo_ArbolB_2.DrawString("30", Font, Brushes.White, 228, 100);
            Nodo_ArbolB_2.DrawLine(LineaAB, 321, 44, 240, 91);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 140, 160, 35, 35);
            Nodo_ArbolB_2.DrawString("27", Font, Brushes.White, 148, 170);
            Nodo_ArbolB_2.DrawLine(LineaAB, 155, 161, 220, 105);            

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 300, 160, 35, 35);
            Nodo_ArbolB_2.DrawString("35", Font, Brushes.White, 308, 170);
            Nodo_ArbolB_2.DrawLine(LineaAB, 315, 160, 254, 105);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 240, 239, 35, 35);
            Nodo_ArbolB_2.DrawString("34", Font, Brushes.White, 250, 249);
            Nodo_ArbolB_2.DrawLine(LineaAB, 255, 239, 301, 175);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 420, 90, 35, 35);
            Nodo_ArbolB_2.DrawString("41", Font, Brushes.White, 430, 100);
            Nodo_ArbolB_2.DrawLine(LineaAB, 358, 44, 435, 90);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 355, 160, 35, 35);
            Nodo_ArbolB_2.DrawString("38", Font, Brushes.White, 365, 170);
            Nodo_ArbolB_2.DrawLine(LineaAB, 372, 160, 421, 105);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 485, 160, 35, 35);
            Nodo_ArbolB_2.DrawString("85", Font, Brushes.White, 495, 170);
            Nodo_ArbolB_2.DrawLine(LineaAB, 503, 161, 454, 105);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 420, 240, 35, 35);
            Nodo_ArbolB_2.DrawString("47", Font, Brushes.White, 428, 249);
            Nodo_ArbolB_2.DrawLine(LineaAB, 436, 240, 486, 174);

            Nodo_ArbolB_2.FillEllipse(Brushes.DarkGoldenrod, 550, 240, 35, 35);
            Nodo_ArbolB_2.DrawString("93", Font, Brushes.White, 560, 249);
            Nodo_ArbolB_2.DrawLine(LineaAB, 565, 240, 519, 174);
        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics Preorden_Arbol_2;
            Preorden_Arbol_2 = CreateGraphics();
            Preorden_Arbol_2.DrawString("Preorden:  ", Font, Brushes.DarkRed, 220, 320);

            Preorden_Arbol_2.DrawString("36, ", Font, Brushes.Black, 290, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("30, ", Font, Brushes.Black, 310, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("27, ", Font, Brushes.Black, 330, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("35, ", Font, Brushes.Black, 350, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("34, ", Font, Brushes.Black, 370, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("41, ", Font, Brushes.Black, 390, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("38, ", Font, Brushes.Black, 410, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("85, ", Font, Brushes.Black, 430, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("47, ", Font, Brushes.Black, 450, 320);
            Thread.Sleep(200);
            Preorden_Arbol_2.DrawString("93. ", Font, Brushes.Black, 470, 320);
            Thread.Sleep(200);

            Graphics Inorden_Arbol_2;
            Inorden_Arbol_2 = CreateGraphics();
            Inorden_Arbol_2.DrawString("Inorden:  ", Font, Brushes.Green, 225, 350);

            Inorden_Arbol_2.DrawString("27, ", Font, Brushes.Black, 290, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("30, ", Font, Brushes.Black, 310, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("34, ", Font, Brushes.Black, 330, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("35, ", Font, Brushes.Black, 350, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("36, ", Font, Brushes.Black, 370, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("38, ", Font, Brushes.Black, 390, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("41, ", Font, Brushes.Black, 410, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("47, ", Font, Brushes.Black, 430, 350);
            Thread.Sleep(200);
            Inorden_Arbol_2.DrawString("85, ", Font, Brushes.Black, 450, 350);
            Thread.Sleep(200);            
            Inorden_Arbol_2.DrawString("93. ", Font, Brushes.Black, 470, 350);
            Thread.Sleep(200);


            Graphics PostOrden_Arbol_2;
            PostOrden_Arbol_2 = CreateGraphics();
            PostOrden_Arbol_2.DrawString("Postorden:  ", Font, Brushes.BlueViolet, 220, 380);

            PostOrden_Arbol_2.DrawString("27, ", Font, Brushes.Black, 290, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("34, ", Font, Brushes.Black, 310, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("35, ", Font, Brushes.Black, 330, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("30, ", Font, Brushes.Black, 350, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("38, ", Font, Brushes.Black, 370, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("47, ", Font, Brushes.Black, 390, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("93, ", Font, Brushes.Black, 410, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("85, ", Font, Brushes.Black, 430, 380);
            Thread.Sleep(200);
            PostOrden_Arbol_2.DrawString("41, ", Font, Brushes.Black, 450, 380);
            Thread.Sleep(200);           
            PostOrden_Arbol_2.DrawString("36. ", Font, Brushes.Black, 470, 380);
            Thread.Sleep(200);

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Menu_De_Acceso Next_Form = new Menu_De_Acceso();
                Next_Form.Show();
                this.Hide();
            }
        }
    }
}
