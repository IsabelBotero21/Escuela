using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos
{
    public class EvaluacionRepositorio
    {
        public string ObtenerEvaluacion(int cantidad = 1)
        {
            string[] Trabajo = { "Quiz", "Ejercicio1", "Exposicion", "Proyecto", "Material" };
            var ListaEvaluaciones = from n1 in Trabajo
                                    select new Evaluacion { Nombre = $"{n1}" };
            return ListaEvaluaciones.OrderBy((Eva) => Eva.UniqueId).Take(cantidad).ToList().First().Nombre;
        }
    }
}