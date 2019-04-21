using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    public class PerroFactorial:ICalcular
    {
        public PerroFactorial(double numero)
        {

        }
        private int resultado;
        

        public double Calcular(double numero)
        {
            resultado = 1;
            if (numero != 0)
            {
                int resultado = 1;
                for (int i = 1; i <= numero; i++)// calculo del factorial del numero.
                { resultado = resultado * i;
                }
                numero = resultado;
             
            }
            else if (numero == 0)
            {
                numero = 1;
             
            }
            return numero;
            
        }
    }
}
