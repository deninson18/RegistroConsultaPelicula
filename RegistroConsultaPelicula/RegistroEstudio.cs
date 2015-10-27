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
    public partial class RegistroEstudio : Form
    {
        public RegistroEstudio()
        {
            InitializeComponent();
        }

        private void GuardarEstudio_Click(object sender, EventArgs e)
        {
            Estudios cine = new Estudios();
            if(estudioIdtextBox.Text.Length == 0)
            {

                cine.NombreEstudio = nombreEstudiotextBox.Text;
                if (cine.Insertar())
                {
                    MessageBox.Show("Estudio no se agrego");
                }
                else
                {
                    MessageBox.Show("Estudio se agrego ");
                }

            }
            else
            {


                cine.EstudioId = Convert.ToInt32(estudioIdtextBox.Text);
                cine.NombreEstudio = nombreEstudiotextBox.Text;
                if (cine.Editar())
                {
                    MessageBox.Show("Estudio no editado");
                }
                else
                {
                    MessageBox.Show("Estudio editado");
                }

            }
        }

        private void eliminarEstudio_Click(object sender, EventArgs e)
        {
             if (estudioIdtextBox.Text.Length > 0)
            {
                Estudios cine = new Estudios();
                cine.EstudioId = Convert.ToInt32(estudioIdtextBox.Text);
                cine.Eliminar();
                MessageBox.Show("estudio ha sido eliminado");

            }else
            {
                MessageBox.Show("estudio no ha sido eliminado");
            }
        }

        private void nuevoEstudio_Click(object sender, EventArgs e)
        {
            estudioIdtextBox.Clear();
            nombreEstudiotextBox.Clear();
        }
    }
}
