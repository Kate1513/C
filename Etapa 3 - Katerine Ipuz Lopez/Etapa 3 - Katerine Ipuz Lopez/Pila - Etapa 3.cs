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
    public partial class Pila___Etapa_3 : Form
    {
        Stack<Pila> Registro_Pila = new Stack<Pila>(); 
        public Pila___Etapa_3()
        {
            InitializeComponent();
        }

        private void Pila___Etapa_3_Load(object sender, EventArgs e)
        {

        }

        private void Tst_RegistrarC_Click(object sender, EventArgs e)
        {
            Pila Registro_Ventas = new Pila();

            Registro_Ventas.IdCliente = Txt_ID.Text;
            Registro_Ventas.NombreC = Txt_NombreC.Text;
            Registro_Ventas.VpCliente = Int32.Parse(Txt_ValorP.Text);
            Registro_Ventas.FechaV = Dtp_FechaR.Value;
            Registro_Ventas.ServCliente = Cmb_ServicioV.Text;
            Registro_Pila.Push(Registro_Ventas);
            Dgv_C.DataSource = null;
            Dgv_C.DataSource = Registro_Pila.ToArray();
            Clear_All();
            Txt_ID.Focus();
        
        }


        public void Clear_All()  

        {
            Txt_ID.Clear();
            Txt_NombreC.Clear();
            Txt_ValorP.Clear();
            Cmb_ServicioV.ResetText();
            Dtp_FechaR.ResetText();
        }

        private void Tst_EliminarC_Click(object sender, EventArgs e)
        {
            if (Registro_Pila.Count != 0)
            {
                Pila Registro_Ventas = new Pila();
                if (MessageBox.Show("Desea eliminar el ultimo registro?", "Mensaje", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Registro_Ventas = Registro_Pila.Pop();
                    Txt_ID.Text = Registro_Ventas.IdCliente;
                    Txt_NombreC.Text = Registro_Ventas.NombreC;
                    Txt_ValorP.Text = Registro_Ventas.VpCliente.ToString();
                                       
                    Dgv_C.DataSource = null;
                    Dgv_C.DataSource = Registro_Pila.ToArray();
                    Clear_All();
                    Txt_ID.Focus();
                }
                    
            }
            else 
            {
                MessageBox.Show("No existen registros en el formulario", "Mensaje");
            }
        }

        private void Lbl_Total_CR_Click(object sender, EventArgs e)
        {

        }

        private void Tst_ReportesC_Click(object sender, EventArgs e)
        {
            Txt_Total_CR.Text = Registro_Pila.Count.ToString();

            double total = 0;
            foreach (DataGridViewRow Conteo in Dgv_C.Rows) 
            {
                total += Convert.ToDouble(Conteo.Cells["VpCliente"].Value); 
            }
            Txt_Total_VP.Text = Convert.ToString(total);
                        
            Dgv_C.DataSource = null;
            Dgv_C.DataSource = Registro_Pila.ToArray();
            Clear_All();
            Txt_ID.Focus();
        }

        private void Dgv_C_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_RegresarMp_Click(object sender, EventArgs e)
        {
            Menu_de_Acceso Next_Form = new Menu_de_Acceso();
            Next_Form.Show();
            this.Hide();
        }

        private void Grb_Reportes_Enter(object sender, EventArgs e)
        {
                   
        }

        private void Txt_Total_VP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tst_Salir_Pïla_Click(object sender, EventArgs e)
        {
            //Menu_de_Acceso Next_Form = new Menu_de_Acceso();
            //Next_Form.Show();
            //this.Hide();

            this.Close();
        }
    }
}
