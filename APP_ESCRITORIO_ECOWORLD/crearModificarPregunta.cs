using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormPrototipos
{
    public partial class crearModificarPregunta : Form
    {
        //Constantes
        private const String CASTELLANO_FACIL   = "castellanoFacil.json";
        private const String CASTELLANO_NORMAL  = "castellanoNormal.json";
        private const String CASTELLANO_DIFICIL = "castellanoDificil.json";
        private const String CATALAN_FACIL      = "catalanFacil.json";
        private const String CATALAN_NORMAL     = "catalanNormal.json";
        private const String CATALAN_DIFICIL    = "catalanDificil.json";
        private const String ENGLISH_FACIL      = "englishFacil.json";
        private const String ENGLISH_NORMAL     = "englishNormal.json";
        private const String ENGLISH_DIFICIL    = "englishDificil.json";
        private const String IDIOMA_CATALAN     = "Català";
        private const String IDIOMA_ESPANOL     = "Español";
        private const String IDIOMA_INGLES      = "English";
        private const String NIVEL_FACIL        = "Fácil";
        private const String NIVEL_NORMAL       = "Normal";
        private const String NIVEL_DIFICIL      = "Difícil";
        //Variables
        private Pregunta pregunta;
        private Boolean seleccionarForm;
        private BindingList<Pregunta> preguntas;
        private String idiomaSeleccionado       = "";
        private String dificultadSeleccionada   = "";
        /// <summary>
        /// Constructor de la clase crearModificarPregunta para CREAR una pregunta
        /// </summary>
        /// <param name="idiomaSeleccionado">Pasamos por parámetro el idioma seleccionado en el JSON</param>
        /// <param name="dificultadSeleccionada">Pasamos por parámetro la dificultad seleccionada en el JSON</param>
        public crearModificarPregunta(String idiomaSeleccionado, String dificultadSeleccionada,
            BindingList<Pregunta> preguntas)
        {
            InitializeComponent();
            this.idiomaSeleccionado     = idiomaSeleccionado;
            this.dificultadSeleccionada = dificultadSeleccionada;
            this.preguntas = preguntas;
            seleccionarForm = true;
            buttonAnadir.Text = "Añadir";
            labelPreguntaActual.Visible = false;
            textBoxPreguntaActual.Visible = false;
            labelEscribirP.Text = "Escribir pregunta";
            this.Text = "Crear pregunta";
        }
        /// <summary>
        /// Constructor de la clase crearModificarPregunta para MODIFICAR una pregunta
        /// </summary>
        /// <param name="idiomaSeleccionado">Pasamos por parámetro el idioma seleccionado en el JSON</param>
        /// <param name="dificultadSeleccionada">Pasamos por parámetro la dificultad seleccionada en el JSON</param>
        /// <param name="pregunta">Pasamos por parámetro la pregunta seleccionada
        /// de la dataGridView</param>
        public crearModificarPregunta(String idiomaSeleccionado, String dificultadSeleccionada,
                    BindingList<Pregunta> preguntas, Pregunta pregunta)
        {
            InitializeComponent();
            this.idiomaSeleccionado = idiomaSeleccionado;
            this.dificultadSeleccionada = dificultadSeleccionada;
            this.preguntas = preguntas;
            this.pregunta = pregunta;
            seleccionarForm = false;
            buttonAnadir.Text = "Modificar";
            labelPreguntaActual.Visible = true;
            textBoxPreguntaActual.Visible = true;
            labelEscribirP.Text = "Modificar pregunta";
            this.Text = "Modificar pregunta";
            cargarDatosModificar();
        }
        /// <summary>
        /// Evento click de buttonAnadirP
        /// </summary>
        private void buttonAnadirP_Click(object sender, EventArgs e)
        {
            if (!seleccionarForm)
            {
                modificarPregunta();
            }
            else
            {
                crearPregunta();
            }
        }
        /// <summary>
        /// Método dónde comprobamos si el archivo existe o no
        /// </summary>
        /// <param name="curFile"></param>
        /// <returns>Devuelve un Boolean, false sino existe(fichero), true si existe(fichero)</returns>
        public Boolean comprobarArchivo(String curFile)
        {
            Boolean existe = false;

            if (File.Exists(curFile))
            {
                existe = true;
            }
            return existe;
        }
        /// <summary>
        /// Método donde leemos un JSON
        /// </summary>
        /// <param name="nombreJason">parámetro que pasamos para buscar si el JSON existe</param>
        public void leerJason(String nombreJason)
        {
            if (comprobarArchivo(nombreJason))
            {
                JArray jArray = JArray.Parse(File.ReadAllText(nombreJason, Encoding.UTF8));
                preguntas = jArray.ToObject<BindingList<Pregunta>>();
            }
            else
            {
                preguntas = new BindingList<Pregunta>();
            }
        }
        /// <summary>
        /// Método donde escribimos un JSON
        /// </summary>
        /// <param name="nombreJason">parámetro que pasamos para buscar si el JSON existe</param>
        public void escribirJason(String nombreJason)
        {
            JArray jArray = (JArray)JToken.FromObject(preguntas);

            StreamWriter fichero = File.CreateText(nombreJason);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(fichero);
            jArray.WriteTo(jsonTextWriter);

            fichero.Close();
        }
        /// <summary>
        /// Método dónde buscamos si una pregunta está repetida
        /// </summary>
        /// <param name="pregunta">Pasamos un objeto pregunta para comparar con nuestra lista de preguntas</param>
        /// <returns>Devuelve un Boolean, false sino está repetida, true si está repetida</returns>
        public Boolean buscarPreguntaRepetida(Pregunta pregunta)
        {
            Boolean encontrado = false;

            foreach (Pregunta item in preguntas)
            {
                if (item.Equals(pregunta))
                {
                    encontrado = true;
                }
            }

            return encontrado;
        }
        /// <summary>
        /// Método para comprobar los fallos del usuario, en este caso, para comprobar que no deje campos vacíos
        /// </summary>
        /// <returns>Devuelve un Boolean, false sino tiene fallos, true si tiene fallos</returns>
        public Boolean comprobarFallosUsuario()
        {
            Boolean fallos = false;
            //comprobar los fallos del usuario y mostrar mensajes por pantalla para avisarle
            if (textBoxEscribirP.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido el enunciado de la pregunta.",
                    "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxEscribirP.Focus();
            }

            else if (textBoxRespuesta1.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido la primera respuesta.", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxRespuesta1.Focus();
            }

            else if (textBoxRespuesta2.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido la segunda respuesta.", "Alerta", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                textBoxRespuesta2.Focus();
            }

            else if (textBoxRespuesta3.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido la tercera respuesta.", "Alerta", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                textBoxRespuesta3.Focus();

            }

            else if (textBoxRespuestaCorrecta.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido la respuesta correcta.", "Alerta", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                textBoxRespuestaCorrecta.Focus();
            }

            else if (textBoxExplicacion.Text.Equals(""))
            {
                fallos = true;
                MessageBox.Show("Error! No ha introducido la explicación de la pregunta.",
                    "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxExplicacion.Focus();
            }

            return fallos;
        }
        /// <summary>
        /// Método dónde filtramos el JSON seleccionado por idioma y dificultad. Comprobamos que la pregunta
        /// introducida no esté repetida con el método buscarPreguntaRepetida y sino está repetida la creamos.
        /// </summary>
        /// <param name="idiomaSeleccionado">Pasamos por parámetro el idioma seleccionado en el JSON</param>
        /// <param name="dificultadSeleccionada">Pasamos por parámetro la dificultad seleccionada en el JSON</param>
        /// <param name="pregunta">Pasamos un objeto de tipo pregunta para modificar los datos en el JSON</param>
        public void crearPreguntaEscribirJSON(String idiomaSeleccioando, String dificultadSeleccionada,
            Pregunta pregunta)
        {
            if (idiomaSeleccionado.Equals(IDIOMA_CATALAN))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    
                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CATALAN_FACIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                   
                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CATALAN_NORMAL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                   
                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CATALAN_DIFICIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_ESPANOL))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CASTELLANO_FACIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CASTELLANO_NORMAL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(CASTELLANO_DIFICIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_INGLES))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(ENGLISH_FACIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(ENGLISH_NORMAL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preguntas.Add(pregunta);
                        escribirJason(ENGLISH_DIFICIL);
                        MessageBox.Show("Pregunta creada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// Evento click de buttonSalir
        /// </summary>
        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Método que usamos para abrir el formulario de Crear Pregunta
        /// </summary>
        public void crearPregunta()
        {
            String Enunciado = "";
            List<String> respuestas = new List<string>();
            String FundamentosRespuestaCorrecta = "";
            Boolean preguntaCreadaCorrectamente = false;


            if (!comprobarFallosUsuario())
            {
                preguntaCreadaCorrectamente = true;

                Enunciado = textBoxEscribirP.Text.Trim();

                respuestas.Add(textBoxRespuesta1.Text.Trim());
                respuestas.Add(textBoxRespuesta2.Text.Trim());
                respuestas.Add(textBoxRespuesta3.Text.Trim());
                respuestas.Add(textBoxRespuestaCorrecta.Text.Trim());

                FundamentosRespuestaCorrecta = textBoxExplicacion.Text.Trim();

                Pregunta pregunta = new Pregunta(Enunciado, respuestas, FundamentosRespuestaCorrecta);

                crearPreguntaEscribirJSON(idiomaSeleccionado, dificultadSeleccionada, pregunta);
            }

            if (preguntaCreadaCorrectamente)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Método que usamos para llamar al formulario Pregunta
        /// </summary>
        public void modificarPregunta()
        {

            Boolean preguntaModificadaCorrectamente = false;

            if (!comprobarFallosUsuario())
            {
                preguntaModificadaCorrectamente = true;

                String Enunciado = textBoxEscribirP.Text.Trim();

                List<String> respuestas = new List<String>();
                respuestas.Add(textBoxRespuesta1.Text.Trim());
                respuestas.Add(textBoxRespuesta2.Text.Trim());
                respuestas.Add(textBoxRespuesta3.Text.Trim());
                respuestas.Add(textBoxRespuestaCorrecta.Text.Trim());

                String FundamentosRespuestaCorrecta = textBoxExplicacion.Text.Trim();

                Pregunta pregunta = new Pregunta(Enunciado, respuestas, FundamentosRespuestaCorrecta);

                modificarPreguntaEscribirJSON(idiomaSeleccionado, dificultadSeleccionada, pregunta);
            }



            if (preguntaModificadaCorrectamente)
            {
                this.Close();
            }

        }
        /// <summary>
        /// Método dónde cargamos los datos de la dataGridView a los textBox del formulario modificar
        /// </summary>
        public void cargarDatosModificar()
        {
            
            textBoxPreguntaActual.Text = pregunta.enunciado;
            textBoxEscribirP.Text = pregunta.enunciado;
            textBoxRespuesta1.Text = pregunta.respuestas[0];
            textBoxRespuesta2.Text = pregunta.respuestas[1];
            textBoxRespuesta3.Text = pregunta.respuestas[2];
            textBoxRespuestaCorrecta.Text = pregunta.respuestas[3];
            textBoxExplicacion.Text = pregunta.fundamentosRespuestaCorrecta;
            
        }
        /// <summary>
        /// Método dónde leemos el JSON seleccionado mediante el idioma y la dificultad
        /// </summary>
        /// <param name="idiomaSeleccionado">Pasamos por parámetro el idioma seleccionado en el JSON</param>
        /// <param name="dificultadSeleccionada">Pasamos por parámetro la dificultad seleccionada en el JSON</param>
        public void leerJasonConIdiomaDificultad(String idiomaSeleccioando, String dificultadSeleccionada)
        {
            if (idiomaSeleccionado.Equals("Català"))
            {
                if (dificultadSeleccionada.Equals("Fácil"))
                {
                    leerJason(CATALAN_FACIL);
                }
                if (dificultadSeleccionada.Equals("Normal"))
                {
                    leerJason(CATALAN_NORMAL);
                }
                if (dificultadSeleccionada.Equals("Difícil"))
                {
                    leerJason(CATALAN_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals("Español"))
            {
                if (dificultadSeleccionada.Equals("Fácil"))
                {
                    leerJason(CASTELLANO_FACIL);
                }
                if (dificultadSeleccionada.Equals("Normal"))
                {
                    leerJason(CASTELLANO_NORMAL);
                }
                if (dificultadSeleccionada.Equals("Difícil"))
                {
                    leerJason(CASTELLANO_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals("English"))
            {
                if (dificultadSeleccionada.Equals("Fácil"))
                {
                    leerJason(ENGLISH_FACIL);
                }
                if (dificultadSeleccionada.Equals("Normal"))
                {
                    leerJason(ENGLISH_NORMAL);
                }
                if (dificultadSeleccionada.Equals("Difícil"))
                {
                    leerJason(ENGLISH_DIFICIL);
                }
            }
        }
        /// <summary>
        /// En esta función filtramos por idioma y dificultad el JSON a trabajar. Lo leemos, comprobamos que la
        /// pregunta no esté repetida y sino lo está, modificamos la pregunta y escribimos en el JSON.
        /// </summary>
        /// <param name="idiomaSeleccioando">Indicamos el idioma seleccionado del JSON en gestionarPreguntas</param>
        /// <param name="dificultadSeleccionada">Indicamos la dificultad seleccionada del JSON en gestionarPreguntas</param>
        /// <param name="pregunta">Pasamos un objeto de tipo pregunta para modificar los datos en el JSON</param>
        public void modificarPreguntaEscribirJSON(String idiomaSeleccioando, String dificultadSeleccionada,
            Pregunta pregunta)
        {
            if (idiomaSeleccionado.Equals(IDIOMA_CATALAN))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(CATALAN_FACIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(CATALAN_NORMAL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(CATALAN_DIFICIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_ESPANOL))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                             pregunta.respuestas);
                        escribirJason(CASTELLANO_FACIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(CASTELLANO_NORMAL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(CASTELLANO_DIFICIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_INGLES))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
 
                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                             pregunta.respuestas);
                        escribirJason(ENGLISH_FACIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(ENGLISH_NORMAL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {

                    if (buscarPreguntaRepetida(pregunta))
                    {
                        MessageBox.Show("Pregunta repetida, no se ha podido crear", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        modificarPregunta(pregunta.enunciado, pregunta.fundamentosRespuestaCorrecta,
                            pregunta.respuestas);
                        escribirJason(ENGLISH_DIFICIL);
                        MessageBox.Show("Pregunta modificada correctamente.", "Información",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// Método donde modificamos la pregunta actual cambiando sus atributos del objeto
        /// </summary>
        /// <param name="Enunciado">Enunciado de la respuesta modificada</param>
        /// <param name="FundamentosRespuestaCorrecta">Explicación de la respuesta correcta modificada</param>
        /// <param name="respuestas">ArrayList con las 4 respuestas modificadas</param>
        public void modificarPregunta(String Enunciado, String FundamentosRespuestaCorrecta,
         List<String> respuestas)
        {
            
            pregunta.enunciado = Enunciado;
            pregunta.fundamentosRespuestaCorrecta= FundamentosRespuestaCorrecta;
            pregunta.respuestas = respuestas;
            
        }

    }
}
