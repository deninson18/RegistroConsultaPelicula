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
    public partial class RegistroActores : Form
    {
        public RegistroActores()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActoresIdtextBox.Clear();
            NombreActortextBox.Clear();
            ApellidoActortextBox.Clear();
        }

        private void ActorGuardar_Click(object sender, EventArgs e)
        {
            Actores actor = new Actores();
            if (ActoresIdtextBox.TextLength == 0)
            {

                actor.Nombre = NombreActortextBox.Text;
                actor.Apellido = ApellidoActortextBox.Text;
                if (actor.Insertar())
                {
                    MessageBox.Show("Actor no se agrego");
                }
                else
                {
                    MessageBox.Show("Actor se agrego ");
                }

            }
            else
            {


              actor.ActoresId = Convert.ToInt32(ActoresIdtextBox.Text);
                actor.Nombre = NombreActortextBox.Text;
                actor.Apellido = ApellidoActortextBox.Text;
                if (actor.Editar())
                {
                    MessageBox.Show("Actor no editado");
                }
                else
                {
                    MessageBox.Show("Actor editado");
                }

            }
        }

        private void ActorEliminar_Click(object sender, EventArgs e)
        {
            if (ActoresIdtextBox.TextLength > 0)
            {
                Actores actor = new Actores();
                actor.ActoresId = Convert.ToInt32(ActoresIdtextBox.Text);
                actor.Eliminar();
                MessageBox.Show("Actor ha sido eliminado");

            }
            else
            {
                MessageBox.Show("Actor no ha sido eliminado");
            }
        }
    }
}

