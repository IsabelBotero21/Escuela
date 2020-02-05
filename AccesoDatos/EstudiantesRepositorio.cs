using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos
{
    public class EstudiantesRepositorio
    {
        private List<Alumno> GenerarAlumnosAlazar(Curso curso)
        {
            string[] nombre1 = { "Ana", "Fabiola", "Sara", "Enriqueta", "Marisol", "Tatiana", "Paola" };
            string[] apellido1 = { "Torres", "Sarmiento", "Lopez", "Restrepo", "Castro", "Vanegas", "Llanos" };
            string[] nombre2 = { "Estefania", "Patricia", "Sandra", "Salome", "Alejandra", "Maria", "Sol" };
            var ListaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return ListaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}