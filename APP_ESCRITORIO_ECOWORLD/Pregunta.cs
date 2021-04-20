using System;
using System.Collections.Generic;

namespace WindowsFormPrototipos
{
    public class Pregunta : IEquatable<Pregunta>
    {
        //ATRIBUTOS
        public String enunciado { get; set; }
        public List<String> respuestas { get; set; }
        public String fundamentosRespuestaCorrecta { get; set; }
        //CONSTRUCTOR
        public Pregunta(String enunciado, List<String> respuestas, String fundamentosRespuestaCorrecta)
        {
            this.enunciado = enunciado;
            this.respuestas = respuestas;
            this.fundamentosRespuestaCorrecta = fundamentosRespuestaCorrecta;
        }
        //MÉTODO EQUALS
        public Boolean Equals(Pregunta other)
        {
            Boolean repetido = false;
            
            if ((other.enunciado.Trim().ToUpper().Equals(this.enunciado.Trim().ToUpper())) &&
                (other.fundamentosRespuestaCorrecta.Trim().ToUpper()
                .Equals(this.fundamentosRespuestaCorrecta.Trim().ToUpper())) &&
                this.respuestas[0].Equals(other.respuestas[0]) &&
                this.respuestas[1].Equals(other.respuestas[1]) &&
                this.respuestas[2].Equals(other.respuestas[2]) &&
                this.respuestas[3].Equals(other.respuestas[3]))
            {
                repetido = true;
            }
            
            return repetido;
        }
    }
}

