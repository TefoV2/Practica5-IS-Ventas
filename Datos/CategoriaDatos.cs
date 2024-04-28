using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos : IDatos<Categoria>
    {
        serviciosprofeEntities contexto;
        CategoriaDatos()
        {
            contexto = new serviciosprofeEntities();
        }
        public bool Actualizar(Categoria item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Categoria item)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }

        public bool Nuevo(Categoria item)
        {
            contexto.Categoria.Add(item);
            contexto.SaveChanges();
            return true;
        }
    }
}
