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
        public DateTime FechaDeclaracion { get; set; }
        public DateTime FechaADeclarar { get; set; }
        public bool Emplazamiento { get; set; }
        private decimal SMLDV { get; }

        public Declaracion(decimal valor, DateTime fechaDeclaracion, DateTime fechaADeclarar, bool emplazamiento)
        {
            Valor = valor;
            FechaDeclaracion = fechaDeclaracion;
            this.Emplazamiento = emplazamiento;
            FechaADeclarar = fechaADeclarar;
            SMLDV = 781242 / 30;
        }

        public string LiquidarSancion()
        {
            var tiempo = FechaDeclaracion - FechaADeclarar;
            if (Valor > 0)
            {
                if (Emplazamiento)
                {
                    //Cuando el Valor es mayor a Cero y con emplazamiento
                    //Sanción por extemporaneidad: Valor Declarado*Cantidad de días de Extemporaneidad*10 %
                    var resultado = Valor * (tiempo.Days) * (decimal)0.1;
                    return $"Sanción por extemporaneidad: {resultado}";
                }
                else
                {
                    //1.Cuando el Valor a Declarar es mayor a Cero y sin emplazamiento
                    //  Sanción por extemporaneidad: Valor Declarado*Cantidad de días de Extemporaneidad*5 %
                    var resultado = Valor * (tiempo.Days) * (decimal)0.05;
                    return $"Sanción por extemporaneidad: {resultado}";
                }
            }
            else
            {
                if (Emplazamiento)
                {
                    //Dado que el Valor a Declarar es 0 y con emplazamiento
                    //Cuando Liquide la sanción
                    //La Sanción por extemporaneidad sin emplazamiento es igual a Cantidad de dias de Extemporaneidad * 2 SMLDV
                    var resultado = (tiempo.Days) * 2 * SMLDV;
                    return $"Sanción por extemporaneidad: {resultado}";
                }
                else 
                {
                    //Dado que el Valor a Declarar es 0 y sin emplazamiento
                    //Cuando Liquide la sanción
                    //La Sanción por extemporaneidad sin emplazamiento es igual Cantidad de días de Extemporaneidad*1 SMLDV
                    var resultado = (tiempo.Days) * SMLDV;
                    return $"Sanción por extemporaneidad: {resultado}";
                }
            }

        }
    }
}
