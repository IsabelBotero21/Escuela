using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
       public class Escuela
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString ();
        string nombre;
        public string Nombre{
            get {return "Copia:" + nombre;}
            set {nombre = value.ToUpper();}
        }
        public int AñoCreacion  { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; internal set; }

        public Escuela (string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

        public Escuela (string nombre, int año, TiposEscuela tipo, string Pais="", string Ciudad="")
        {
           (Nombre, AñoCreacion) = (nombre, año);
           this.Pais = Pais;
           this.Ciudad = Ciudad;
        } 
        
        public override string ToString()
        {
            return $"Nombre:{Nombre}, AñoCreacion:{AñoCreacion}, \nTipoEscuela:{TipoEscuela}, Ciudad:{Ciudad}";
        }
    }
}