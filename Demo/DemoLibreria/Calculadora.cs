using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria
{
    public class Calculadora
    {
        public static decimal sumar(decimal numero1, decimal numero2) 
        {
            return numero1 + numero2;
        }

        public static decimal restar(decimal numero1, decimal numero2) => numero1 - numero2;

        public static Func<decimal, decimal, decimal> multiplicar = (n1, n2) => n1 * n2;
        public static decimal dividir(decimal numero1, decimal numero2)
        {
            return numero1 / numero2;
        }
    }
}
