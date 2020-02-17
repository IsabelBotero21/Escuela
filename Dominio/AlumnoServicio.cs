using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
namespace Etapa1.Dominio
{
    public class AlumnoServicio
    {
        //Traer alumnos
        public Alumno alumnoMayorNota(Escuela escuela)
        {
            var alumnoConMayorNota = new Alumno();
            float notaMasAlta = 0;
            var almacenarAlum = new List<Alumno>();
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    alumno.Evaluacion.ForEach(evaluacion =>
                    {
                        almacenarAlum.Add(alumno);
                        if (evaluacion.Nota > notaMasAlta)
                        {
                            notaMasAlta = evaluacion.Nota;
                            alumnoConMayorNota = alumno;
                        }
                    });
                });
            });
            return alumnoConMayorNota;
        }
        public List<Alumno> rangoNota(Escuela escuela)
        {
            float alumnoRango;
            float sumatoriaNota = 0;
            float contadorNotas = 0;
            float prom = 0;
            var alumnosEnRango = new List<Alumno>();
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    alumno.Evaluacion.ForEach(evaluacion =>
                    {
                        sumatoriaNota += evaluacion.Nota;
                        contadorNotas++;
                        sumatoriaNota = 0;
                        contadorNotas = 0;
                        prom = 0;
                    });
                    prom = sumatoriaNota / contadorNotas;
                    if ((prom >= 1) && (prom < 5))
                    {
                        alumnoRango = prom;
                        alumnosEnRango.Add(alumno);
                    }
                });
            });
            return alumnosEnRango;
        }

        public List<Alumno> AlumnoPalabra(Escuela escuela, char S)
        {
            var alumnosEncontrados = new List<Alumno>();
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    if (alumno.Nombre.StartsWith(S))

                    {
                        alumnosEncontrados.Add(alumno);
                    }

                });
            });
            return alumnosEncontrados;

        }

    }
}