using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Generico<T>
    {
        public T campo { get; set; }
        // public Generico(T campo) { this.campo = campo; }
        
        public void mensaje() 
        {
            Console.WriteLine($"Tipo de dato: {campo.GetType().FullName}");
        }
    }
}
