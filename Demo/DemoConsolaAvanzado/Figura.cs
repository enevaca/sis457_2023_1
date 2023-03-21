using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    public abstract class Figura
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }

    public class Cuadrado: Figura 
    {
        readonly decimal lado;
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public override decimal area() => lado * lado;

        public override decimal perimetro() { return lado * 4; }
    }
}
