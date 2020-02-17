using static System.Console;

using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using Etapa1.Dominio;
using Etapa1.UI;

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
            WriteLine(new CalculadorNotas().CalcularModaNota(engine.Escuela));
            Printer.WriteTitle("Alumno con mayor nota");
            var alumno = new AlumnoServicio().alumnoMayorNota(engine.Escuela);
            WriteLine($"Nombre:{alumno.Nombre}"); Printer.WriteTitle("Alumnos letra ");
            Printer.WriteTitle("Rango de notas ");
            var rango = new AlumnoServicio().rangoNota(engine.Escuela);
            foreach (var alum in rango)
            {
                WriteLine($"Nombre:{alum.Nombre}");
            }

            Printer.WriteTitle("Alumnos Encontrados ");
            var alumEncont = new AlumnoServicio().AlumnoPalabra(engine.Escuela, 'S');
            foreach (var alu in alumEncont)
            {
                WriteLine($"Nombre:{alu.Nombre}");
            }
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