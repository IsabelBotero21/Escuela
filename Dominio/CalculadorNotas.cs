using CoreEscuela.Entidades;
using Etapa1.AccesoDatos;

namespace Etapa1.Dominio {
    public class CalculadorNotas {
        public Escuela Escuela { get; set; }
        private void CalcularNotaMasAlta (Curso curso) {
        var cursos = new CursoRepositorio().ObtenerCursos(); 
        for (int i = 0; i < 5; i++)
        {
           

        }

        }
        private void CalcularPromedioNotas (Curso curso) { }

    }
}