using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingre el numero de operaciones a realizar");
            int Operaciones= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero con el que desea operar");
            double numero = Convert.ToDouble(Console.ReadLine());
            Calculadora calculadora = new Calculadora(numero);
            
            for (int i = 1; i <= Operaciones; i++)
            {
                Console.WriteLine("Ingrese el tipo de operacion que quiere realizar");
                Console.WriteLine("[0] Sumar 5");
                Console.WriteLine("[1] Fibonacci");
                Console.WriteLine("[2] Factorial");
                Console.WriteLine("[3] Cubo");
                Console.WriteLine("[4] Cuadrado");
                int x = int.Parse(Console.ReadLine());
                calculadora.Calcular(x);
                Console.WriteLine(calculadora.GetNumero());
                Console.ReadLine();
            }
        }
    }
}
