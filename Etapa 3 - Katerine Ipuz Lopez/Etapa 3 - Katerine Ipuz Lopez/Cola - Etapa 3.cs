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
    public partial class Cola___Etapa_3 : Form
    {
        Queue<Cola> Registro_Cola = new Queue<Cola>();
        public Cola___Etapa_3()
        {
            InitializeComponent();
        }                        

        private void Tst_RegistrarC_Click(object sender, EventArgs e)
        {
            {                
                Cola Registro_Viajes = new Cola();

                Registro_Viajes.NombreC = Txt_NombreC.Text;
                Registro_Viajes.Edad = Convert.ToInt32(Txt_Edad.Text);
                Registro_Viajes.ValorV = Convert.ToDouble(Txt_ValorV.Text);
                int edad = Convert.ToInt32(Txt_Edad.Text);
                double valorV = Convert.ToDouble(Txt_ValorV.Text);
                Registro_Viajes.TotalViaje = Registro_Viajes.Calcular_Descuento(valorV, edad);
                Registro_Viajes.Genero = Cmb_Genero.Text;
                Registro_Viajes.DestinoV = Cmb_DestinoV.Text;
                Registro_Cola.Enqueue(Registro_Viajes);
                Dgv_C.DataSource = null;
                Dgv_C.DataSource = Registro_Cola.ToArray();
                Clear_All();
                Txt_NombreC.Focus();
            }
        }
        public void Clear_All()

        {
            Txt_NombreC.Clear();
            Txt_Edad.Clear();            
            Txt_ValorV.Clear();
            Cmb_Genero.ResetText();
            Cmb_DestinoV.ResetText();
        }
               
        private void Tst_Salir_Cola_Click(object sender, EventArgs e)
        {
            Menu_de_Acceso Next_Form = new Menu_de_Acceso();
            Next_Form.Show();
            this.Hide();
        }
        private void Cola___Etapa_3_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Edad_Click(object sender, EventArgs e)
        {

        }

        private void Tst_EliminarC_Click(object sender, EventArgs e)
        {
            if (Registro_Cola.Count != 0)
            {
                Cola Registro_Viajes = new Cola();
                if (MessageBox.Show("Desea eliminar el primer registro?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Registro_Viajes = Registro_Cola.Dequeue();
                    Txt_NombreC.Text = Registro_Viajes.NombreC;
                    Txt_Edad.Text = Convert.ToString(Txt_Edad.Text);
                    Txt_ValorV.Text = Registro_Viajes.ValorV.ToString();

                    Dgv_C.DataSource = null;
                    Dgv_C.DataSource = Registro_Cola.ToArray();
                    Clear_All();
                    Txt_NombreC.Focus();
                }

            }
            else
            {
                MessageBox.Show("No existen registros en el formulario", "Mensaje");
            }
        }

        private void Tst_ReportesC_Click(object sender, EventArgs e)
        {
            Txt_Total_CR.Text = Registro_Cola.Count.ToString();

            double total = 0;
            foreach (DataGridViewRow Conteo in Dgv_C.Rows)
            {
                total += Convert.ToDouble(Conteo.Cells["TotalViaje"].Value);
            }
            Txt_Total_VP.Text = Convert.ToString(total);

            Dgv_C.DataSource = null;
            Dgv_C.DataSource = Registro_Cola.ToArray();
            Clear_All();
            Txt_NombreC.Focus();
        }

        private void Tst_Salir_Cola_Click_1(object sender, EventArgs e)
        {
            //Menu_de_Acceso Next_Form = new Menu_de_Acceso();
            //Next_Form.Show();
            //this.Hide();

            this.Close();
        }
    }
}

