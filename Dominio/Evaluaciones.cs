using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public float Nota { get; set; }

        public string Asignatura {get; set;}

        public Evaluacion() => UniqueId = Guid.NewGuid().ToString ();

    }
}