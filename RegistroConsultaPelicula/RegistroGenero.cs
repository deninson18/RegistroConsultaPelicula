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
    public partial class RegistroGenero : Form
    {
        public RegistroGenero()
        {
            InitializeComponent();
        }

        private void generoGuardar_Click(object sender, EventArgs e)
        {
            Generos gen = new Generos();
            if (generoIdtextBox.Text.Length == 0)
            {

                gen.DescripcionGen = descripcionGenero.Text;
                if (gen.Insertar())
                {
                    MessageBox.Show("Genero no se agrego");
                }
                else
                {
                    MessageBox.Show("Genero se agrego ");
                }

            } else {
                

                gen.GeneroId = Convert.ToInt32(generoIdtextBox.Text);
                gen.DescripcionGen = descripcionGenero.Text;
                if (gen.Editar())
                {
                    MessageBox.Show("Genero no editado");
                } else
                {
                    MessageBox.Show("Genero editado");
                    }

            }
        }

        private void generoNuevo_Click(object sender, EventArgs e)
        {
            generoIdtextBox.Clear();
            descripcionGenero.Clear();
        }

        private void generoEliminar_Click(object sender, EventArgs e)
        {
            if (generoIdtextBox.TextLength > 0)
            {
                Generos gen = new Generos();
                gen.GeneroId = Convert.ToInt32(generoIdtextBox.Text);
                gen.Eliminar();
                MessageBox.Show("genero ha sido eliminado");

            }else
            {
                MessageBox.Show("genero no ha sido eliminado");
            }
        }
    }
}
