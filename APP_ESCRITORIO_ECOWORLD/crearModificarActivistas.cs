using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormPrototipos
{
    public partial class crearModificarActivistas : Form
    {
        BindingList<Activista> activistas = new BindingList<Activista>();
        gestionarActivistas aModificar= new gestionarActivistas();
        String rutaImagen;
        OpenFileDialog rutaCarpeta = new OpenFileDialog();
        bool modificar;

        public crearModificarActivistas(gestionarActivistas modificaremos, bool modificar) //si modificar true modificamos, si false creamos
        {
            InitializeComponent();
            aModificar = modificaremos;
            this.modificar = modificar;
        }

        private bool compruebaFormatoActivista(String nombre, String puntuacion, String frasePersonaCat, String frasePersonaEsp, String frasePersonaEng)
        {
           
            //Activista rellenado correctamente
            bool correcte = false;
            int result;
            if (textBoxNombreModificarActivista.Text.Equals(""))
            {
                MessageBox.Show("Error! No ha introducido ningún nombre.",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombreModificarActivista.Focus();
            }
            else if (comboBox1Puntos.SelectedItem.ToString().Equals("")) 
            {
                    MessageBox.Show("Puntuación vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1Puntos.Focus();
            }
            else if (!Int32.TryParse(comboBox1Puntos.SelectedItem.ToString(), out result))
            {
                MessageBox.Show("Puntuación incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1Puntos.Focus();
            }
            else if (textBoxCat.Text.Equals(""))
            {
                MessageBox.Show("Frase catalán vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCat.Focus();
            }
            else if (textBoxEsp.Text.Equals(""))
            {
                MessageBox.Show("Frase español vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEsp.Focus();
            }
            else if (textBoxEng.Text.Equals(""))
            {
                MessageBox.Show("Frase inglés vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEng.Focus();
            }
            else if (string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
            {
                MessageBox.Show("Ruta de imagen inválida o vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                correcte = true;
            }

            return correcte;
        }

        private void modificamos(object sender, EventArgs e)
        {
            if (activistas.Count >= 0)
            {
                Activista antiguo = new Activista();
                antiguo.nombre = aModificar.RetornaNom();
                antiguo.frasePersonaCat = aModificar.RetornaFraseCat();
                antiguo.frasePersonaEsp = aModificar.RetornaFraseEsp();
                antiguo.frasePersonaEng = aModificar.RetornaFraseEng();
                antiguo.puntuacion = aModificar.RetornaPunt();
                if (aModificar.RetornaRuta() != null)
                {
                   // antiguo.rutaImagen = aModificar.RetornaRuta();
                    antiguo.rutaImagen = rutaCarpeta.FileName;
                }
                else
                {
                    MessageBox.Show("Ruta de imagen inválida o vacía", "No se ha modificado el activista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (compruebaFormatoActivista(antiguo.nombre, antiguo.puntuacion.ToString(), antiguo.frasePersonaCat, antiguo.frasePersonaEsp, antiguo.frasePersonaEng) && !rutaCarpeta.FileName.Equals("") && !rutaCarpeta.FileName.Equals(null))
                {
                    Activista nuevo = new Activista();
                    if (!antiguo.nombre.Equals(nuevo.nombre))
                    {
                        nuevo.nombre = textBoxNombreModificarActivista.Text;
                    }
                    if (!antiguo.frasePersonaCat.Equals(nuevo.frasePersonaCat))
                    {
                        nuevo.frasePersonaCat = textBoxCat.Text;
                    }
                    if (!antiguo.frasePersonaEsp.Equals(nuevo.frasePersonaEsp))
                    {
                        nuevo.frasePersonaEsp = textBoxEsp.Text;
                    }
                    if (!antiguo.frasePersonaEng.Equals(nuevo.frasePersonaEng))
                    {
                        nuevo.frasePersonaEng = textBoxEng.Text;
                    }
                    if (!antiguo.puntuacion.Equals(nuevo.puntuacion))
                    {
                        nuevo.puntuacion = Int32.Parse(comboBox1Puntos.SelectedItem.ToString());
                    }
                    if (!antiguo.rutaImagen.Equals(rutaCarpeta))
                    {
                        nuevo.rutaImagen = rutaCarpeta.FileName;
                    }
                    if (!pictureBoxActivista.ImageLocation.Equals(rutaImagen)&&!rutaCarpeta.FileName.Equals(null))
                    {
                        pictureBoxActivista.ImageLocation = rutaImagen;
                    }
                

                    //carga array json en dataGridView
                    JArray o1 = JArray.Parse(File.ReadAllText("Activistas.json", Encoding.UTF8));
                    activistas = o1.ToObject<BindingList<Activista>>();

                    //escribir
                    if (!nuevo.Equals(antiguo))
                     {
                        if (!activistas.Contains(nuevo))
                        {
                            activistas.Remove(antiguo);
                            activistas.Add(nuevo);
                        }
                        else
                        {
                            MessageBox.Show("Activista repetido, no se ha podido modificar", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                     }
                    
                    //volver a escribir
                    File.WriteAllText("Activistas.json", JsonConvert.SerializeObject(activistas));
                    aModificar.gestionarActivistas_activated(sender, e);

                    MessageBox.Show("Activista modificado correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                
            }
        }

        private void creamos(object sender, EventArgs e)
        {
            int valor;

            if(comboBox1Puntos.SelectedIndex < 0)
            {
                MessageBox.Show("Error! No ha introducido los puntos requeridos.",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (compruebaFormatoActivista(textBoxNombreModificarActivista.Text,
                comboBox1Puntos.SelectedItem.ToString(),textBoxCat.Text, textBoxEsp.Text,
                textBoxEng.Text) && Int32.TryParse(comboBox1Puntos.SelectedItem.ToString(),
                out valor) && !rutaCarpeta.FileName.Equals("")
                && !rutaCarpeta.FileName.Equals(null))
            {
                Activista nuevoActivista = new Activista();

                nuevoActivista.nombre = textBoxNombreModificarActivista.Text;
                nuevoActivista.frasePersonaCat = textBoxCat.Text;
                nuevoActivista.frasePersonaEsp = textBoxEsp.Text;
                nuevoActivista.frasePersonaEng = textBoxEng.Text;
                nuevoActivista.rutaImagen = rutaImagen;

                nuevoActivista.puntuacion = Int32.Parse(comboBox1Puntos.SelectedItem.ToString());

                String destino = nuevoActivista.nombre.Trim();
                destino = destino.Replace(" ", "");
                destino = destino.ToLower();
                File.Copy(rutaImagen, destino);
                rutaImagen = destino;
                nuevoActivista.rutaImagen = rutaImagen;

               //deserialize 
               JArray o1 = JArray.Parse(File.ReadAllText("Activistas.json", Encoding.UTF8));
                activistas = o1.ToObject<BindingList<Activista>>();
                if (!activistas.Contains(nuevoActivista))
                {
                    activistas.Add(nuevoActivista);
                }
                else
                {
                    MessageBox.Show("Activista repetido, no se ha podido crear", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                //escribia correctamente!!
                File.WriteAllText("Activistas.json", JsonConvert.SerializeObject(activistas));
                //gestionaActAnterior.gestionarActivistas_Load(sender, e);
                aModificar.gestionarActivistas_activated(sender, e);

                MessageBox.Show("Activista creado correctamente.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            
        }

        private void buttonModificarActivista_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                modificamos(sender, e);
                
            }
            else
            {
               creamos(sender, e);
            }
        }

        private void modificarActivistas_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                textBoxNombreModificarActivista.Text = aModificar.RetornaNom();
                comboBox1Puntos.SelectedItem = aModificar.RetornaPunt().ToString();
                textBoxCat.Text = aModificar.RetornaFraseCat();
                textBoxEsp.Text = aModificar.RetornaFraseEsp();
                textBoxEng.Text = aModificar.RetornaFraseEng();
                rutaCarpeta.FileName = aModificar.RetornaRuta();
                pictureBoxActivista.ImageLocation = aModificar.RetornaRuta();
            }
           
        }

        private void buttonModificarFotoActivista_Click(object sender, EventArgs e)
        {
            if (!compruebaArchivo() || rutaCarpeta.FileName.Equals(""))
            {
                MessageBox.Show("No se ha modificado el activista", "Archivo vacío o incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( !string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
            {
                pictureBoxActivista.ImageLocation = rutaImagen;
            }
        }

        private bool compruebaArchivo()
        {
            bool correcto = false;
         
            using (rutaCarpeta = new OpenFileDialog())
            {
                rutaCarpeta.Filter = "Image files (*.jpg,  *.png) | *.jpg; *.png";
                rutaCarpeta.Multiselect = false;
                if (rutaCarpeta.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
                {

                    rutaImagen = rutaCarpeta.FileName;
                    correcto = true;
                }
            }
            return correcto;
        }



        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
