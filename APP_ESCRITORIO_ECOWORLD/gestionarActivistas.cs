using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormPrototipos
{
    public partial class gestionarActivistas : Form
    {
        BindingList<Activista> activistas;
    
        public gestionarActivistas()
        {
            InitializeComponent();
         
        }

        private void buttonCrearActivista_Click(object sender, EventArgs e)
        {
            crearModificarActivistas btnCrearActivista = new crearModificarActivistas(this, false);
            btnCrearActivista.ShowDialog();
        }

        public void gestionarActivistas_activated(object sender, EventArgs e)
        {
            JArray o1 = JArray.Parse(File.ReadAllText("Activistas.json", Encoding.UTF8));
            activistas = o1.ToObject<BindingList<Activista>>();

            dataGridViewActivistas.DataSource = null;
            dataGridViewActivistas.DataSource = activistas;
        }

        private void buttonEliminarActivista_Click(object sender, EventArgs e)
        {
            if (!comprobarJSON())
            {
                if (comprovaEliminar())
                {
                    Activista borrar = (Activista) dataGridViewActivistas.CurrentRow.DataBoundItem; 
                    File.Delete(borrar.nombre);

                    activistas.RemoveAt(buscaIndex());
                    File.WriteAllText("Activistas.json", JsonConvert.SerializeObject(activistas));

                    MessageBox.Show("Activista eliminado correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public int buscaIndex()
        {
            return dataGridViewActivistas.CurrentCell.RowIndex;
        }

        public bool comprovaEliminar()
        {
            Boolean confirmarEliminar = false;

            confirmarEliminarA btnEliminarA = new confirmarEliminarA(this); 
            btnEliminarA.ShowDialog();

            if (btnEliminarA.getConfirmar())
            {
                confirmarEliminar = true;
            }

            return confirmarEliminar;

        }

        private void buttonModificarActivista_Click(object sender, EventArgs e)
        {
            if (!comprobarJSON())
            {
                crearModificarActivistas btnModificarActivista = new crearModificarActivistas(this, true);
                btnModificarActivista.ShowDialog();
            }
        }

        public int RetornaPunt()
        {
            Activista nou = new Activista();
            nou=(Activista) dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.puntuacion;
        }

        public String RetornaNom()
        {
            Activista nou = new Activista();
            nou = (Activista)dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.nombre;
        }

        public String RetornaFraseCat()
        {
            Activista nou = new Activista();
            nou = (Activista)dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.frasePersonaCat;
        }

        public String RetornaFraseEsp()
        {
            Activista nou = new Activista();
            nou = (Activista)dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.frasePersonaEsp;
        }

        public String RetornaFraseEng()
        {
            Activista nou = new Activista();
            nou = (Activista)dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.frasePersonaEng;
        }

        public String RetornaRuta()
        {
            Activista nou = new Activista();
            nou = (Activista)dataGridViewActivistas.CurrentRow.DataBoundItem;
            return nou.rutaImagen;
        }

        public void gestionarActivistas_Load(object sender, EventArgs e)
        {
            if (!comprobarGestionarActivistas())
            {
                dataGridViewActivistas.AutoGenerateColumns = false;
                String nomArxiu = "Activistas.json";

                if (File.Exists(nomArxiu))
                {
                    JArray o1 = JArray.Parse(File.ReadAllText(nomArxiu, Encoding.UTF8));
                    activistas = o1.ToObject<BindingList<Activista>>();
                    //aqui refrescamos grid
                    dataGridViewActivistas.DataSource = null;
                    dataGridViewActivistas.DataSource = activistas;
                }
                else
                {
                    MessageBox.Show("No existe el archivo");
                }
            }
        }

        public Boolean comprobarJSON()
        {
            Boolean dataGridViewVacia = false;

            if(dataGridViewActivistas.SelectedRows.Count <= 0)
            {
                dataGridViewVacia = true;
                MessageBox.Show("Error! No ha seleccionado ningún activista.",
                     "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dataGridViewVacia;
        }

        public Boolean comprobarGestionarActivistas()//si lleno devuelve false, si vacio true
        {
            Boolean dataGridViewVacia = false;

            if (dataGridViewActivistas.SelectedRows.Count > 0)
            {
                dataGridViewVacia = true;
            }
            return dataGridViewVacia;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarActivistas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Fichero guardado automáticamente.", "Salir",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
