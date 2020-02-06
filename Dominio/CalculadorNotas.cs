using System.Collections.Generic;
using CoreEscuela.Entidades;
using Etapa1.AccesoDatos;

namespace Etapa1.Dominio
{
    public class CalculadorNotas
    {
        public Escuela Escuela { get; set; }
        private void CalcularNotaMasAlta(Curso curso)
        {

            foreach (var cur in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignatura)
                {
                    foreach (var alumno in curso.Alumno)
                    {
                        alumno.Evaluacion = new List<Evaluacion>();

                    }

                }
            }

        }
        private void CalcularPromedioNotas(Curso curso)
        {



        }
    }

}
