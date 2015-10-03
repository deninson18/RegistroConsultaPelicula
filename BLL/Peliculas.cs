using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Peliculas
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Imbd { get; set; }
        public int Calificacion { get; set; }
        public int Ano { get; set; }
        public int CategoriaId { get; set; }

        public Peliculas()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Imbd = 0;
            this.Calificacion = 0;
            this.Ano = 0;
            this.CategoriaId = 0;
        }

        public Peliculas(int fPeliculaId, string fTitulo, string fDescripcion, int fImdb, int fCalificacion, int fAno, int fCategoriaID)
        {
            this.PeliculaId = fPeliculaId;
            this.Titulo = fTitulo;
            this.Descripcion = fDescripcion;
            this.Imbd = fImdb;
            this.Calificacion = fCalificacion;
            this.Ano = fAno;
            this.CategoriaId = fCategoriaID;

        }
    }
}
