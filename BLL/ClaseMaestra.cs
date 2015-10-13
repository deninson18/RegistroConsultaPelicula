using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   abstract class ClaseMaestra
    {
        public abstract bool Insertar();

        public abstract bool Editar();

        public abstract bool Eliminar();

        public abstract bool Buscar(int IdBuscado);


    }
}
