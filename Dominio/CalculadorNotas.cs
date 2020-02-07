using System.Collections.Generic;
using CoreEscuela.Entidades;
using Etapa1.AccesoDatos;

namespace Etapa1.Dominio {
    public class CalculadorNotas {
        public Escuela Escuela { get; set; }
        private float CalcularNotaMasAlta (Escuela escuela) {
            float notaMasAlta = 0;
            Escuela.Cursos.ForEach (Curso => {
                Curso.Alumno.ForEach (Alumno =>
                 {
                    Alumno.Evaluacion.ForEach(Evaluacion =>
                    {
                    if (Evaluacion.Nota
                        > notaMasAlta) {
                        notaMasAlta = Evaluacion.Nota;
                    };
                });
            });
             });
            return notaMasAlta;

        }
        private double CalcularPromedioNotas (Curso curso) {
   double Promedio = 0;
            Escuela.Cursos.ForEach (Curso => {
                Curso.Alumno.ForEach (Alumno => {
                    Alumno.Evaluacion.ForEach (Evaluacion => {
                        Promedio = Evaluacion.Nota / 5;
                    });
                });
          
            });
           return Promedio; 
        }
    }
}