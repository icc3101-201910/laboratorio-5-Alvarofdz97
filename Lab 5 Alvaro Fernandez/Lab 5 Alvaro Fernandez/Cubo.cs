using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    public class Cubo:ICalcular
    {
        public Cubo(double numero)
        {

        }
        public double Calcular(double numero)
        {
            numero = Math.Pow(numero, 3);
            return numero;
        }
    }
}
