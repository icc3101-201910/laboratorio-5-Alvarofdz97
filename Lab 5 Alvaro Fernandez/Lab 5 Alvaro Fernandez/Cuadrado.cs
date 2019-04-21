using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{   
    public class Cuadrado:ICalcular
    {
        private double numero;
        public Cuadrado(double numero)
        {
            this.numero = numero;

        }
        public double Calcular(double numero)
        {
            numero = Math.Pow(numero, 2);
            return numero;
        }
    }
}
