using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos
{
    public class AsignaturaRepositorio
    {
          private List<Asignatura> ObtenerAsignatura(Curso curso)
        {
            string[] A1 = { "Matemáticas", "Ed fisica", "Castellano", "Ciencias", "Inglés" };
            var ListaAsignaturas = from a1 in A1
                                   select new Asignatura { Nombre = $"{a1}" };
            return ListaAsignaturas.OrderBy((asig) => asig.UniqueId).ToList();
        }

    }
}