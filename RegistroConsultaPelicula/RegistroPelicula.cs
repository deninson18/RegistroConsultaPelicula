using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegistroConsultaPelicula
{
    public partial class RegistroPelicula : Form
    {
        public RegistroPelicula()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peliculas p = new Peliculas();
    
            p.Titulo = Convert.ToString(TitulotextBox.Text);
            p.Descripcion = Convert.ToString(DescripciontextBox.Text);
            p.CategoriaId = Convert.ToInt32(CategoriatextBox.Text);
            p.Imbd = Convert.ToInt32(ImdbtextBox.Text);
            p.Ano = Convert.ToInt32(AnotextBox.Text);
            p.Insertar();


        }

        private void ImdbtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
