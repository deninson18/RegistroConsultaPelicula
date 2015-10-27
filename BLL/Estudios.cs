using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Estudios : ClaseMaestra
    {
        public int EstudioId{ get; set; }
        public string NombreEstudio { get; set; }

        public Estudios()
        {
            this.EstudioId = 0;
            this.NombreEstudio = "";
        }
        
        
        
        public override bool Buscar(int IdBuscado)
        {
            Conectar conector = new Conectar();
            try
            {
                DataTable dt;
                dt = conector.ObtenerDatos(String.Format("select * from Estudios whele estudioId={0}", EstudioId));
                this.NombreEstudio = dt.Rows[0]["Nombre"].ToString();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("update Estudios set nombreEstudio='{0}' where estudioId={1}", this.NombreEstudio, this.EstudioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("delete from Estudios where estudioId='{0}'", this.EstudioId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("insert Into Estudios(nombreEstudio) values('{0}')", this.NombreEstudio));
            return retorno;
        }
    

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            Conectar conexion = new Conectar();
            return conexion.ObtenerDatos(string.Format(" select " + Campos + " from Estudios where " + Condicion + Orden));

        }
    }
}

