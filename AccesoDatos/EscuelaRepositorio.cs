using CoreEscuela.Entidades;

namespace Etapa1.AccesoDatos
{
    public class EscuelaRepositorio
    {
            public Escuela Escuela { get; set; }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, Pais: "Colombia", Ciudad: "Abejorral");

        }
    }
}