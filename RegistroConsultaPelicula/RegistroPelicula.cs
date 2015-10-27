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

        private void rLimpiarbutton_Click(object sender, EventArgs e)
        {
            TitulotextBox.Clear();
            ImdbtextBox.Clear();
            AnotextBox.Clear();
            CategoriatextBox.Clear();
            CalificaciontextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void rEliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void generoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPelicula_Load(object sender, EventArgs e)
        {
            Generos gen = new Generos();
            Actores actor = new Actores();
            Estudios cine = new Estudios();
            
            for (int i = 0; i < gen.Listado(" Descripcion ", "1=1", "").Rows.Count; i++)
            {
                generoComboBox.Items.Add(gen.Listado(" Descripcion ", "1=1", "").Rows[i]["Descripcion"]);
            }
            
            for (int i = 0; i < actor.Listado(" Nombre ", "1=1", "").Rows.Count; i++)
            {
                ActoresComboBox.Items.Add(actor.Listado(" Nombre ", "1=1", "").Rows[i]["Nombre"]);
            }
            

            for (int i = 0; i < cine.Listado(" NombreEstudio ", "1=1", "").Rows.Count; i++)
            {
                estudioComboBox.Items.Add(cine.Listado(" NombreEstudio ", "1=1", "").Rows[i]["NombreEstudio"]);
            }
            
        }

        private void rEliminarbutton_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    }

