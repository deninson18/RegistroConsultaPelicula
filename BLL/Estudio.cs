using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Estudio : ClaseMaestra
    {
        public int estudioId{ get; set; }
        public string nombreEstudio { get; set; }

        public Estudio()
        {
            this.estudioId = 0;
            this.nombreEstudio = "";
        }
        
        
        
        public override bool Buscar(int IdBuscado)
        {
            Conectar conector = new Conectar();
            try
            {
                DataTable dt;
                dt = conector.ObtenerDatos(String.Format("select * from Estudios whele estudioId={0}", estudioId));
                this.nombreEstudio = dt.Rows[0]["Nombre"].ToString();
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
            conector.Ejecutar(string.Format("update Estudios set nombreEstudio='{0}' where estudioId={1}", this.nombreEstudio, this.estudioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("delete from Estudios where estudioId='{0}'", this.estudioId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("insert Into Estudios(nombreEstudio) values('{0}')", this.nombreEstudio));
            return retorno;
        }
    

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}

