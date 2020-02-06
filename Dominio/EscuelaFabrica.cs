using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using Etapa1.AccesoDatos;


namespace Etapa1.Dominio
{
    public class EscuelaFabrica
    {
        public Escuela Escuela { get; set; }
        public Escuela FabricarEscuela()
        {
            Escuela = new EscuelaRepositorio().ObtenerEscuela();
            var cursos = new CursoRepositorio().ObtenerCursos();
            Escuela.Cursos = cursos;

            CurAlumno();
            CurAsignatura();
            CurEvaluacion();

            void CurAlumno()
            {
                Random rdn = new Random();
                foreach (var curso in Escuela.Cursos)
                {
                    var obtenerAlumno = new AlumnoRepositorio();
                    int cantRandom = rdn.Next(5, 20);
                    curso.Alumno = obtenerAlumno.ObtenerAlumno(cantRandom);
                }
            }
            void CurAsignatura()
            {
                foreach (var curso in Escuela.Cursos)
                {
                    var obtenerAsignatura = new AsignaturaRepositorio();
                    curso.Asignatura = obtenerAsignatura.ObtenerAsignatura();
                }
            }
            void CurEvaluacion()
            {
                foreach (var curso in Escuela.Cursos)
                {
                    foreach (var asignatura in curso.Asignatura)
                    {
                        foreach (var alumno in curso.Alumno)
                        {
                            alumno.Evaluacion = new List<Evaluacion>();
                            Random rd = new Random();
                            for (int i = 0; i < 5; i++)
                            {
                                var notaSinAproximar = (float)(5 * rd.NextDouble());
                                var evaluacionRepositorio = new EvaluacionRepositorio();
                                evaluacionRepositorio.ObtenerEvaluacion();

                                var evaluacion = new Evaluacion
                                {
                                    Nombre = evaluacionRepositorio.ObtenerEvaluacion(),
                                    Asignatura = asignatura.Nombre,
                                    Nota = (float)Math.Round(notaSinAproximar, 2)
                                };
                                alumno.Evaluacion.Add(evaluacion);
                            }

                        }
                    }
                }
            }
            return Escuela;
        }


    }
}



