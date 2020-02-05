using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos {
    public class EscuelaRepositorio {
        public Escuela ObtenerEscuela() {
            return new Escuela ("Platzi Academy", 2012, TiposEscuela.Primaria, Pais: "Colombia", Ciudad: "Abejorral");
        }
    }
}