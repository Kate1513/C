using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Etapa_2___Katerine_Ipuz_Lopez
{
    class Simulador
    {
        
        public string ID_Cliente { get; set; }
        public string Nombre_C { get; set; }
        public int Plazo_Dias { get; set; }
        public decimal Inversion { get; set; }
        public string Pago_Int { get; set; }
        public string Fecha_I { get; set; }
        public string Fecha_F { get; set; }


        //Metodo para calcular los intereses de los clientes
        public decimal Calcular_Intereses()
        {
            decimal Pago_Interes = 0;

            if (Pago_Int == "Mensual")
            {
                Pago_Interes = (Inversion * 0.0035m);
            }

            if (Pago_Int == "Vencimiento")
            {
                Pago_Interes = (Inversion * (0.0035m * (Plazo_Dias /30)));
            }

            return Pago_Interes;
        }
                      

    }


}

