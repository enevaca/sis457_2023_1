﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    class Estudiante : Persona
    {
        public string carnetUniversitario { get; set; }

        public override void saludar()
        {
            Console.WriteLine($"Soy Estudiante {nombres} {apellidos} C.U. {carnetUniversitario}");
        }
    }
}
