using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    class Persona
    {
        public string cedulaIdentidad { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public long celular { get; set; } // Int64

        public virtual void saludar()
        {
            Console.WriteLine($"Hola {nombres} {apellidos}");
        }
    }
}
