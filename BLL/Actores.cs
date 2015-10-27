using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Actores: ClaseMaestra
    {
        public int ActoresId { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }

        public Actores()
        {
            this.ActoresId = 0;
            this.Nombre = "";
            this.Apellido = "";
        }

        public override bool Insertar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("insert Into Actores(Nombre,Apellido) values('{0}','{1}')", this.Nombre,this.Apellido));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("update Actores set Nombre='{0}', Apellido='{1}' where ActoresId={2}", this.Nombre,this.Apellido, this.ActoresId));
            return retorno;


        }

        public override bool Eliminar()
        {
            bool retorno = false;
            Conectar conector = new Conectar();
            conector.Ejecutar(string.Format("delete from Actores where ActoresId={0}", this.ActoresId));
            return retorno;

        }

        public override bool Buscar(int IdBuscado)
        {
            Conectar conector = new Conectar();
            try
            {
                DataTable dt;
                dt = conector.ObtenerDatos(String.Format("select * from Actores whele ActoresId={0}", ActoresId));
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellido = dt.Rows[1]["Apellido"].ToString();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            Conectar conexion = new Conectar();
            return conexion.ObtenerDatos(string.Format(" select " + Campos + " from Actores where " + Condicion + Orden));
        }
    }
}
