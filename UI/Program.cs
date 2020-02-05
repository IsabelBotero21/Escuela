using static System.Console;

using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using CoreEscuela.Util;
using Etapa1.UI;

namespace CoreEscuela.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var formularioSN = new FormularioSolicitudNotas();
            formularioSN.Inicializar();
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, Cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void FormularioSolicitudNotas()
        {
            throw new NotImplementedException();
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
