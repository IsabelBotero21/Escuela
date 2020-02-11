using static System.Console;

using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using CoreEscuela.Util;
using Etapa1.UI;
using Etapa1.Dominio;

namespace CoreEscuela.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var formularioSN = new FormularioSolicitudNotas();
            formularioSN.Inicializar();
            var engine = new EscuelaFabrica();
            engine.FabricarEscuela();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, Cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela);
            Printer.WriteTitle("Nota mas alta");
            WriteLine(new CalculadorNotas().CalcularNotaMasAlta(engine.Escuela));
            Printer.WriteTitle("Nota menor");
            WriteLine(new CalculadorNotas().CalcularNotaMenor(engine.Escuela));
            Printer.WriteTitle("Promedio");
            WriteLine(new CalculadorNotas().CalcularPromedioNotas(engine.Escuela));
              Printer.WriteTitle("Moda");
            WriteLine(new CalculadorNotas().CalcularModa(engine.Escuela));
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
