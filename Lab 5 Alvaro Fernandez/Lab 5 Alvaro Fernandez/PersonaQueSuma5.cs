using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Alvaro_Fernandez
{
    public class PersonaQueSuma5:ICalcular
    {
        public PersonaQueSuma5(double numero)
        {

        }


        public double Calcular(double numero)
        {
            numero += 5;
            return numero;

        }
        
        
        
    }
}
