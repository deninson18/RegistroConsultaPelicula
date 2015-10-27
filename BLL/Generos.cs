using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class Generos : ClaseMaestra
    {
        public int GeneroId { get; set; }
        public string DescripcionGen { get; set; }

        public Generos()
        {
            this.GeneroId = 0;
            this.DescripcionGen = "";
        }

        public override bool Buscar(int IdBuscado)
        {
            Conectar conector = new Conectar();
            try
            {
                DataTable dt;
                dt = conector.ObtenerDatos(String.Format("select * from Generos whele GeneroId={0}", GeneroId));
                this.DescripcionGen = dt.Rows[0]["Descripcion"].ToString();
                return true;

            }catch(Exception)
            {
                return false;
            }

        }

        public override bool Editar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("update Generos set Descripcion='{0}' where GeneroId={1}", this.DescripcionGen, this.GeneroId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("delete from Generos where GeneroId='{0}'", this.GeneroId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("insert Into Generos(Descripcion) values('{0}')",this.DescripcionGen));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            Conectar conexion = new Conectar();
            return conexion.ObtenerDatos(string.Format(" select " + Campos + " from Generos where " + Condicion + Orden));

        }
    }
}
