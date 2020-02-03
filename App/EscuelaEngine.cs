using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela.Entidades {
   public class EscuelaEngine {
    public Escuela Escuela {get; set;}
 public EscuelaEngine(){}
  public void Inicializar ()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, Pais: "Colombia", Ciudad: "Abejorral");
            var cursos = CargarCursos();    
        }
        private string GenerarEvaluacionesAlazar(int cantidad = 1)
        {
            string [] Trabajo ={"Quiz", "Ejercicio1", "Exposicion", "Proyecto", "Material"};
            var ListaEvaluaciones = from n1 in Trabajo
                                    select new Evaluacion { Nombre = $"{n1}" };
            return ListaEvaluaciones.OrderBy((Eva)=>Eva.UniqueId).Take(cantidad).ToList().First().Nombre;
        }
        private List<Asignatura> CargarAsignaturas(int cantidad = 5)
      {
            string [] A1 ={"Matemáticas", "Ed fisica", "Castellano", "Ciencias", "Inglés"};
            var ListaAsignaturas = from a1 in A1
                                    select new Asignatura { Nombre = $"{a1}" };
            return ListaAsignaturas.OrderBy((asig)=>asig.UniqueId).Take(cantidad).ToList();
        }
        private List<Alumno> GenerarAlumnosAlazar(int cantidad)
        {
            string [] nombre1 ={"Ana", "Fabiola", "Sara", "Enriqueta", "Marisol", "Tatiana", "Paola"};
            string [] apellido1 ={"Torres", "Sarmiento", "Lopez", "Restrepo", "Castro", "Vanegas", "Llanos"};
            string [] nombre2 ={"Estefania", "Patricia", "Sandra", "Salome", "Alejandra", "Maria", "Sol" };
            var ListaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {Nombre=$"{n1} {n2} {a1}"};
            return ListaAlumnos.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();
        }
        private List<Curso> CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre="101", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="201", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="301", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="401", Jornada=TiposJornada.Tarde},
                new Curso(){Nombre="501", Jornada=TiposJornada.Tarde},
            };
//random
            Random rdn = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantRandom = rdn.Next(5,20);
                curso.Alumno = GenerarAlumnosAlazar(cantRandom);
            }
            foreach (var curso in Escuela.Cursos)
            {
                curso.Asignatura = CargarAsignaturas();
            } 
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
                            var notaSinAproximar = (float)(5* rd.NextDouble());
                            var evaluacion = new Evaluacion
                            {
                              Nombre = GenerarEvaluacionesAlazar(),
                              Asignatura = asignatura.Nombre,
                              Nota =(float)Math.Round(notaSinAproximar, 2)
                            };
                            alumno.Evaluacion.Add(evaluacion);
                        }
                       
                    }
                }
            }
            return Escuela.Cursos;
        }
    }
}    

