using System.Collections.Generic;
using CoreEscuela.Entidades;
using Etapa1.AccesoDatos;

namespace Etapa1.Dominio
{
    public class CalculadorNotas
    {
        public Escuela Escuela { get; set; }
        public float CalcularNotaMasAlta(Escuela escuela)
        {
            float notaMasAlta = 0;
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    alumno.Evaluacion.ForEach(evaluacion =>
                            {
                                if (evaluacion.Nota
                                 > notaMasAlta)
                                {
                                    notaMasAlta = evaluacion.Nota;
                                };
                            });
                });
            });
            return notaMasAlta;
        }
        public float CalcularNotaMenor(Escuela escuela)
        {
            float menorNota = 5;
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    alumno.Evaluacion.ForEach(evaluacion =>
                            {
                                if (evaluacion.Nota
                                 < menorNota)
                                {
                                    menorNota = evaluacion.Nota;
                                };
                            });
                });
            });
            return menorNota;
        }
        public float CalcularPromedioNotas(Escuela escuela)
        {
            float sumatoriaNota = 0;
            float contadorNotas = 0;
            escuela.Cursos.ForEach(curso =>
            {
                curso.Alumno.ForEach(alumno =>
                {
                    alumno.Evaluacion.ForEach(evaluacion =>
                    {
                        sumatoriaNota += evaluacion.Nota;
                        contadorNotas++;
                    });
                });

            });
            return sumatoriaNota / contadorNotas;
        }
    }
}


