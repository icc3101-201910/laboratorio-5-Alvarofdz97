using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    public class Calculadora
    {
        public List<ICalcular> calculadoras;
        private double numero;
        public Calculadora(double numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
            calculadoras.Add(new PersonaQueSuma5(numero));//agregamos los "trabajadores" a la lista
            calculadoras.Add(new RobotFibonacci(numero));
            calculadoras.Add(new PerroFactorial(numero));
            calculadoras.Add(new Cubo(numero));
            calculadoras.Add(new Cuadrado(numero));



        }
        public double GetNumero()
        {
            return numero;
        }
        public double Calcular(int x){
            Random rnd = new Random();
            int index = rnd.Next(0,6);
            numero = calculadoras[x].Calcular(numero);
            return numero;
            
            
            
            

           
        }
    }
}
