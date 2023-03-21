using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Inmutable
    {
        readonly int atributo1;
        public Inmutable(int atributo1)
        {
            this.atributo1 = atributo1;
        }

        public void cambiarValor()
        {
            // this.atributo1 = 568;
        }
    }
}
