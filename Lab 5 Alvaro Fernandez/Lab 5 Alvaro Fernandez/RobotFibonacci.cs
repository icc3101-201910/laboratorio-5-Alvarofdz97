using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    public class RobotFibonacci:ICalcular
    {
        public RobotFibonacci(double numero)
        {

        }
        public double Calcular(double numero)
        {
            double a = ((1 + Math.Sqrt(5)) / 2);// Base para calcular el numero fibonacci
            double b = ((1 - Math.Sqrt(5)) / 2);
            numero = (Math.Pow(a,numero)-Math.Pow(b,numero)) / Math.Sqrt(5);
          return numero;
        }
    }
}
