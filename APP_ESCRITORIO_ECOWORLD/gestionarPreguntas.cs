using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormPrototipos
{
    public partial class gestionarPreguntas : Form
    {
        //constantes
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
        BindingList<Pregunta> preguntas;
        Boolean botonAbrirJSONPulsado = false;
        String idiomaSeleccionado     = "";
        String dificultadSeleccionada = "";
        /// <summary>
        /// Constructor del formulario gestionarPreguntas
        /// </summary>
        public gestionarPreguntas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento click de buttonEliminarPregunta
        /// </summary>
        private void buttonEliminarPregunta_Click(object sender, EventArgs e)
        {
            if (!comprobarComboBox() && !comprobarJSON())
            {
                confirmarEliminarP btnEliminar = new confirmarEliminarP();

                if (btnEliminar.ShowDialog() == DialogResult.OK)
                {
                    eliminarPreguntaSeleccionada();
                    MessageBox.Show("Pregunta eliminada correctamente.", "Información",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    escribirJasonConIdiomaDificultad(idiomaSeleccionado, dificultadSeleccionada);
                }

                leerJasonConIdiomaDificultad(idiomaSeleccionado, dificultadSeleccionada);
            }

        }
        /// <summary>
        /// Evento click de buttonCrearPregunta
        /// </summary>
        private void buttonCrearPregunta_Click(object sender, EventArgs e)
        {
            if (!comprobarComboBox())
            {
                crearModificarPregunta btnCrearPregunta = new crearModificarPregunta(idiomaSeleccionado, dificultadSeleccionada,
                    preguntas);
                btnCrearPregunta.ShowDialog();
                //leerJasonConIdiomaDificultad(idiomaSeleccionado, dificultadSeleccionada);
            }
        }
        /// <summary>
        /// Evento de buttonModificarPregunta
        /// </summary>
        private void buttonModificarPregunta_Click(object sender, EventArgs e)
        {
            if (!comprobarComboBox() && !comprobarJSON())
            {
                crearModificarPregunta btnModificar = new crearModificarPregunta(idiomaSeleccionado,
                    dificultadSeleccionada,preguntas,(Pregunta)dataGridViewListaPreguntas.CurrentRow.DataBoundItem);
                btnModificar.ShowDialog();
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

            dataGridViewListaPreguntas.DataSource = null;
            dataGridViewListaPreguntas.DataSource = preguntas;
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
        /// En esta función eliminamos la pregunta seleccionada de la lista de preguntas y de la dataGridView de 
        /// preguntas
        /// </summary>
        /// <param name="dataGridViewPreguntas">dataGridViewPreguntas que contiene el enunciado de las preguntras
        /// introducidas</param>
        /// <param name="preguntas">Lista de tipo pregunta con todas las preguntas introducidas</param>
        public void eliminarPreguntaSeleccionada()
        {
            foreach (DataGridViewRow item in this.dataGridViewListaPreguntas.SelectedRows)
            {
                preguntas.Remove((Pregunta)item.DataBoundItem);
            }
        }
        /// <summary>
        /// Evento FormClosed del formulario gestionarPreguntas
        /// </summary>
        private void gestionarPreguntas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!comprobarDatos())
            {
                escribirJasonConIdiomaDificultad(idiomaSeleccionado, dificultadSeleccionada);
                MessageBox.Show("Fichero guardado automáticamente.", "Salir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Evento click de buttonAbrirJSON
        /// </summary>
        private void buttonAbrirJSON_Click(object sender, EventArgs e)
        {
            botonAbrirJSONPulsado = true;

            if (!comprobarComboBox())
            {
                idiomaSeleccionado = comboBoxIdioma.Text;
                dificultadSeleccionada = comboBoxDificultad.Text;
                leerJasonConIdiomaDificultad(idiomaSeleccionado, dificultadSeleccionada);
            }            
        }
        /// <summary>
        /// Evento Activated del formulario gestionarPreguntas
        /// </summary>
        private void gestionarPreguntas_Activated(object sender, EventArgs e)
        {
            dataGridViewListaPreguntas.AutoGenerateColumns = false;
            dataGridViewListaPreguntas.DataSource = null;
            dataGridViewListaPreguntas.DataSource = preguntas;
        }
        /// <summary>
        /// Método dónde comprobamos si el usuario ha introducido dificultad y nivel para leer el JSON
        /// </summary>
        /// <returns>Devuelve un Boolean, false sino tiene fallos, true si tiene fallos</returns>
        public Boolean comprobarComboBox()
        {

            Boolean errores = false;

            if (comboBoxIdioma.Text.Equals(""))
            {
                errores = true;
                MessageBox.Show("No has seleccionado un idioma", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (comboBoxDificultad.Text.Equals(""))
            {
                errores = true;
                MessageBox.Show("No has seleccionado una dificultad", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!botonAbrirJSONPulsado)
            {
                errores = true;
                MessageBox.Show("No ha cargado ningún fichero, debe pulsar el botón abrir.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return errores;
        }
        /// <summary>
        /// Método dónde comprobamos si el usuario ha introducido todos los datos
        /// </summary>
        /// <returns>Devuelve un Boolean, false sino tiene fallos, true si tiene fallos</returns>
        public Boolean comprobarDatos()
        {

            Boolean errores = false;

            if (comboBoxIdioma.Text.Equals(""))
            {
                errores = true;
            }

            else if (comboBoxDificultad.Text.Equals(""))
            {
                errores = true;
            }

            else if (!botonAbrirJSONPulsado)
            {
                errores = true;
            }

            if (errores)
            {
                MessageBox.Show("No ha hecho modificaciones.", "Salir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return errores;
        }
        /// <summary>
        /// Método dónde leemos el JSON seleccionado mediante el idioma y la dificultad
        /// </summary>
        /// <param name="idiomaSeleccionado">Pasamos por parámetro el idioma seleccionado en el JSON</param>
        /// <param name="dificultadSeleccionada">Pasamos por parámetro la dificultad seleccionada en el JSON</param>
        public void leerJasonConIdiomaDificultad(String idiomaSeleccioando, String dificultadSeleccionada)
        {
            if (idiomaSeleccionado.Equals(IDIOMA_CATALAN))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    leerJason(CATALAN_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    leerJason(CATALAN_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    leerJason(CATALAN_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_ESPANOL))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    leerJason(CASTELLANO_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    leerJason(CASTELLANO_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    leerJason(CASTELLANO_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_INGLES))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    leerJason(ENGLISH_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    leerJason(ENGLISH_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    leerJason(ENGLISH_DIFICIL);
                }
            }
        }
        /// <summary>
        /// Método donde escribimos en el JSON filtrando el JSON a escribir por idioma y dificultad.
        /// </summary>
        /// <param name="idiomaSeleccioando">Indicamos el idioma seleccionado del JSON en gestionarPreguntas</param>
        /// <param name="dificultadSeleccionada">Indicamos la dificultad seleccionada del JSON en gestionarPreguntas</param>
        public void escribirJasonConIdiomaDificultad(String idiomaSeleccioando, String dificultadSeleccionada)
        {
            if (idiomaSeleccionado.Equals(IDIOMA_CATALAN))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    escribirJason(CATALAN_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    escribirJason(CATALAN_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    escribirJason(CATALAN_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_ESPANOL))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    escribirJason(CASTELLANO_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    escribirJason(CASTELLANO_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    escribirJason(CASTELLANO_DIFICIL);
                }
            }

            if (idiomaSeleccionado.Equals(IDIOMA_INGLES))
            {
                if (dificultadSeleccionada.Equals(NIVEL_FACIL))
                {
                    escribirJason(ENGLISH_FACIL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_NORMAL))
                {
                    escribirJason(ENGLISH_NORMAL);
                }
                if (dificultadSeleccionada.Equals(NIVEL_DIFICIL))
                {
                    escribirJason(ENGLISH_DIFICIL);
                }
            }
        }
        /// <summary>
        /// Método donde comprobamos que se pueda cargar correctamente el JSON, es decir,
        /// a seleccionado idioma y dificultad del JSON.
        /// </summary>
        /// <returns>Devuelve un Boolean, false sino tiene fallos, true si tiene fallos</returns>
        public Boolean comprobarJSON()
        {
            Boolean dataGridViewVacia = false;

            if(dataGridViewListaPreguntas.CurrentRow == null)
            {
                dataGridViewVacia = true;
                MessageBox.Show("Error! No ha seleccionado ninguna pregunta.",
                     "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dataGridViewVacia;
        }
        /// <summary>
        /// Evento de buttonSalir
        /// </summary>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
