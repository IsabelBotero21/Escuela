using System;
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
        public void CalcularModaNota(Escuela escuela)
        {

            var array = new List<float>();
            escuela.Cursos.ForEach(curso =>
                   {
                       curso.Alumno.ForEach(alumno =>
                       {
                           alumno.Evaluacion.ForEach(evaluacion =>
                           {
                               array.Add(evaluacion.Nota);
                           });
                       });
                   });
        }

        public float CalcularModa(Array)
        {
            float moda = 0;
            float repeticionesNumero = 0;
            float repeticionesNumeroMayor = 0;
            for (int i = 0; i < array.Count; i++)
            {
                repeticionesNumero = 0;


                for (int j = 0; j < array.Count; j++)
                {

                    if (array[j] == array[i])
                    {
                        repeticionesNumero++;
                    }

                    if (j == array.Count - 1)
                    {
                        if (repeticionesNumero > repeticionesNumeroMayor)
                        {
                            moda = array[i];
                            repeticionesNumeroMayor = repeticionesNumero;
                        }
                    }
                }
            }
            return moda;

        }
    }
}





