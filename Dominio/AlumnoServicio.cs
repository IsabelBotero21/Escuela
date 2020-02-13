using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace Etapa1.Dominio {
    public class AlumnoServicio {
        //Traer alumnos
        public Alumno alumnoMayorNota(Escuela escuela)
        {
     var alumnoConMayorNota =new Alumno();
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
        
             public float rangoNota (Escuela escuela) {
            float alumnoRango;
            var rango = new List<Alumno> ();
            escuela.Cursos.ForEach (curso => {
                curso.Alumno.ForEach (alumno => {
                    alumno.Evaluacion.ForEach (evaluacion => {
                        if ((evaluacion.Nota>=3)&&(evaluacion.Nota<5))
                        {
                            alumnoRango = evaluacion.Nota;
                            rango.Add(alumno);
                        }
                     });
                });
            });
            return rangoNota(escuela);
        }
    }
}