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
    public partial class Lista___Etapa_3 : Form
    {
        List<Lista> Registro_Lista = new List<Lista>();

        public Lista___Etapa_3()
        {
            InitializeComponent();
            Tst_Consultar.Enabled = false;
            Tst_EliminarC.Enabled = false;
        }

        private void Tst_RegistrarC_Click(object sender, EventArgs e)
        {
            Lista Registro_Empleados = new Lista();

            Registro_Empleados.ID_Empleado = Txt_ID.Text;
            Registro_Empleados.NombreE = Txt_NombreE.Text;
            Registro_Empleados.N_Empresa = Txt_N_Empresa.Text;
            Registro_Empleados.CargoE = Cmb_CargoE.Text;
            Registro_Empleados.FechaI = Dtp_FechaI.Value;            
            Registro_Lista.Add(Registro_Empleados);
            Dgv_E.DataSource = null;
            Dgv_E.DataSource = Registro_Lista.ToArray();
            Tst_Consultar.Enabled = true;
            Clear_All();
            Txt_ID.Focus();
        }
        public void Clear_All()

        {
            Txt_ID.Clear();
            Txt_NombreE.Clear();
            Txt_N_Empresa.Clear();
            Cmb_CargoE.ResetText();
            Dtp_FechaI.ResetText();
            Dtp_FechaS.ResetText();
        }

        private Lista GetLista(string Id_Empleado)
        {
            foreach (Lista Registro_Empleados in Registro_Lista)
            {
                if (Registro_Empleados.ID_Empleado == Id_Empleado)
                {
                    return Registro_Empleados;
                }
            }
            return null;
        }

        private void Tst_Consultar_Click(object sender, EventArgs e)
        {
            if (Validar_Id () == false)
            {
                return;
            }
            Lista Registro_Empleados = GetLista(Txt_ID.Text);
            if (Registro_Empleados == null)
            {
                Error_P.SetError(Txt_ID, "La identificacion " + "No se encuentra en el sistema");
                Clear_All();
                Txt_ID.Focus();
                return;
            }
            else
            {
                Error_P.SetError(Txt_ID, "");
                Txt_ID.Text = Registro_Empleados.ID_Empleado;
                Txt_NombreE.Text = Registro_Empleados.NombreE;
                Txt_N_Empresa.Text = Registro_Empleados.N_Empresa;
                Tst_EliminarC.Enabled = true;
            }
        }

        private bool Validar_Id()
        {
            if (String.IsNullOrEmpty(Txt_ID.Text))
            {
                Error_P.SetError(Txt_ID, "Ingrese una identificacion valida");
                Txt_ID.Focus();
                return false;
            }
            Error_P.SetError(Txt_ID, "");
            return true;            
        }

        private void Tst_EliminarC_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show(this, "Confirma eliminar el registro?",
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (Respuesta == DialogResult.Yes)
            {
                foreach(Lista Registro_Empleados in Registro_Lista)
                {
                    if (Registro_Empleados.ID_Empleado == Txt_ID.Text)
                    {
                        Registro_Lista.Remove(Registro_Empleados);
                        break;
                    }
                }
                Clear_All();
                Dgv_E.DataSource = null;
                Dgv_E.DataSource = Registro_Lista;
                Tst_EliminarC.Enabled = false;
            }
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
