using System;
using System.Windows.Forms;

namespace WindowsFormPrototipos
{
    public partial class confirmarEliminarA : Form
    {
        gestionarActivistas eliminaremos;
        bool confirmar = false;
        public confirmarEliminarA(gestionarActivistas anterior)
        {
            InitializeComponent();
            eliminaremos = anterior;
        }

        public bool getConfirmar()
        {
            return confirmar;
        }

        private void buttonCancelarA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptarA_Click(object sender, EventArgs e)
        {
            confirmar = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
