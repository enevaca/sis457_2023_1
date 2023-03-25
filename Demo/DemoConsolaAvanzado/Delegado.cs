using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Delegado
    {
        public delegate string Reverse(string s);
        public static string reverseString(string s)
        { 
            return new string(s.Reverse().ToArray());
        }
        public static void imprimir(string s)
        {
            Console.WriteLine(s);
        }

        public static Action<string> imp = Delegado.imprimir;

        public static Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
        public static Predicate<int> mayorEdad = e => e > 18;
    }
}
