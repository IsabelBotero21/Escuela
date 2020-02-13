using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace Etapa1.Dominio {
    public class AlumnoServicio {
        //Traer alumnos
        public float alumnoMayorNota (Escuela escuela) {
            string alumnoConMayorNota = null;
            float notaMasAlta = 0;
            var array = new List<Alumno> ();
            escuela.Cursos.ForEach (curso => {
                curso.Alumno.ForEach (alumno => {
                    alumno.Evaluacion.ForEach (evaluacion => {
                        array.Add (alumno);
                        if (evaluacion.Nota > notaMasAlta)
                        {
                            notaMasAlta = evaluacion.Nota;
                            alumnoConMayorNota = alumno;
                        }
                    });
                });
            });
            return notaMasAlta;
        }
    }
}