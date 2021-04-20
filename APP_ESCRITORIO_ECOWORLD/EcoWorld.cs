using System;
using System.Windows.Forms;

namespace WindowsFormPrototipos
{
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Constructor de la clase FormPrincipal
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento click botón Gestionar Preguntas
        /// </summary>
        private void buttonGestionarPreguntas_Click(object sender, EventArgs e)
        {
            gestionarPreguntas btnGestionar = new gestionarPreguntas();
            btnGestionar.ShowDialog();
        }
        /// <summary>
        /// Evento click botón Gestionar Personajes
        /// </summary>
        private void buttonGestionarPersonages_Click(object sender, EventArgs e)
        {
            gestionarActivistas btnGestionarActivistas = new gestionarActivistas();
            btnGestionarActivistas.ShowDialog();
        }
    }
}
