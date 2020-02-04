using static System.Console;

using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, Cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela);
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");
            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre:{curso.Nombre}, Id: {curso.UniqueId}");
            }
        }
    }
}
