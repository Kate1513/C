using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_3___Katerine_Ipuz_Lopez
{
    public class Cola
    {
        public string NombreC { get; set; }
        public int Edad { get; set; }
        public double ValorV { get; set; }
        public string Genero { get; set; }
        public string DestinoV { get; set; }
        public double TotalViaje { get; set; }


        public double Calcular_Descuento (double valorV, int edad)
        {
            if (edad <= 12 && edad >= 1)
            {
                TotalViaje = valorV * 0.90;
            }
            else
            {
                TotalViaje = valorV * 0.95;
            }
            return TotalViaje;
        }
    }    
}
