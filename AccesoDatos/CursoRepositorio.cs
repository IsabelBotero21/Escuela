using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos
{
    public class CursoRepositorio
    {
        public List<Curso> ObtenerCursos()
        {
            var cursos = new List<Curso>() {
                new Curso () { Nombre = "101", Jornada = TiposJornada.Manana },
                new Curso () { Nombre = "201", Jornada = TiposJornada.Manana },
                new Curso () { Nombre = "301", Jornada = TiposJornada.Manana },
                new Curso () { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso () { Nombre = "501", Jornada = TiposJornada.Tarde },

            };
            return cursos;
        }
    }
}