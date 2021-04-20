using System;

namespace WindowsFormPrototipos
{
    class Activista : IEquatable<Activista>
    {
        public String nombre { get; set; }
        public int puntuacion { get; set; }
        public String rutaImagen { get; set; } 
        public String frasePersonaCat {get; set;}
        public String frasePersonaEsp { get; set; }
        public String frasePersonaEng { get; set; }

        public bool Equals(Activista check)
        {
            Boolean equal = false;

            if (this.nombre.Equals(check.nombre) && this.puntuacion == check.puntuacion 
                && this.rutaImagen.Equals(check.rutaImagen)
                && this.frasePersonaCat.Equals(check.frasePersonaCat)
                && this.frasePersonaEsp.Equals(check.frasePersonaEsp)
                && this.frasePersonaEng.Equals(check.frasePersonaEng))
            {
                equal = true;
            }

            return equal;
        }
    }
}
