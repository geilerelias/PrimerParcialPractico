using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Declaracion
    {
        decimal Valor { get; set; }
        public DateTime Fecha { get; set; }

        public Declaracion(int valor, DateTime Fecha)
        {
            Valor = valor;
            this.Fecha = Fecha;
        }

   
        public string  LiquidarSancion()
        {
            return "";
        }
    }
}
