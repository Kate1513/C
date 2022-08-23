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
    public partial class Simulador_AwVillas : Form
    {
        public Simulador_AwVillas()
        {
            InitializeComponent();
        }

        Simulador Intereses_Cliente = new Simulador();

        //Metodo para limpiar todas las casillas
        private void Button1_Click(object sender, EventArgs e)
        {
            Txt_ID.Clear();
            TxtNombre_C.Clear();
            TxtInversion_C.Clear();
            CmbPlazo_Dias.Text = ("");
            CmbPago_Rend.Text = ("");
            DtpFecha_Hoy.ResetText();
            DtpFecha_Venc.ResetText();
            Lbl_Id_C.Text = ("");
            Lbl_Nombre_C.Text = ("");
            Lbl_Inversion_C.Text = ("");
            Lbl_PLazo_D_C.Text = ("");
            Lbl_Pago_I_C.Text = ("");
            Lbl_FechaI_C.Text = ("");
            Lbl_FechaV_C.Text = ("");
            Lbl_Pago_Int.Text = ("");

        }

        //Metodo Boton Salir de la aplicacion
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)

        {
            Intereses_Cliente.ID_Cliente = Txt_ID.Text;
            Intereses_Cliente.Nombre_C = TxtNombre_C.Text;
            Intereses_Cliente.Inversion = Convert.ToDecimal(TxtInversion_C.Text);
            Intereses_Cliente.Plazo_Dias = Convert.ToInt32(CmbPlazo_Dias.SelectedItem.ToString());
            Intereses_Cliente.Pago_Int = (CmbPago_Rend.SelectedItem.ToString());
            Intereses_Cliente.Fecha_I = DtpFecha_Hoy.Value.ToString();
            Intereses_Cliente.Fecha_F = DtpFecha_Venc.Value.ToString();

            Lbl_Id_C.Text = Intereses_Cliente.ID_Cliente;
            Lbl_Nombre_C.Text = Intereses_Cliente.Nombre_C;
            Lbl_Inversion_C.Text = Intereses_Cliente.Inversion.ToString();
            Lbl_PLazo_D_C.Text = Intereses_Cliente.Plazo_Dias.ToString();
            Lbl_Pago_I_C.Text = Intereses_Cliente.Pago_Int;
            Lbl_FechaI_C.Text = Intereses_Cliente.Fecha_I;
            Lbl_FechaV_C.Text = Intereses_Cliente.Fecha_F;
            Lbl_Pago_Int.Text = Intereses_Cliente.Calcular_Intereses().ToString("C");
                                                                          
        }       
             
        //Metodo para que calcule automaticamente la fecha en que finaliza el contrato
        private void CmbPlazo_Dias_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtpFecha_Venc.Value = DtpFecha_Hoy.Value.AddDays(int.Parse(CmbPlazo_Dias.Text));
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_C_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
 
        