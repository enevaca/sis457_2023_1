using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    public interface IVehiculo
    {
        void acelerar(int kmh);
        void frenar();
        void girar(int angulo);
    }

    class Avion : IVehiculo
    {
        public void acelerar(int kmh)
        {
            Console.WriteLine($"Acelerando {kmh} km/h");
        }

        public void frenar()
        {
            Console.WriteLine("Freando...");
        }

        public void girar(int angulo)
        {
            Console.WriteLine($"Griando {angulo} grados");
        }
    }
}
