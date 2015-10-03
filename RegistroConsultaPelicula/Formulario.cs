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
            Consulta c = new Consulta();
            c.Show();
        }
    }
}
