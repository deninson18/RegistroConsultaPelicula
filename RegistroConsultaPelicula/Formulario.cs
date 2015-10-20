using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroConsultaPelicula
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPelicula r = new RegistroPelicula();
            r.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroGenero registro = new RegistroGenero();
            registro.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void peliculasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }

        private void registroDeActoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroActores registro = new RegistroActores();
            registro.Show();
        }

        private void registroDeEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEstudio registro = new RegistroEstudio();
            registro.Show();
        }
    }
}
