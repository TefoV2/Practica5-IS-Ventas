using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        serviciosprofeEntities contexto;
        ClienteDatos()
        {
            contexto = new serviciosprofeEntities();
        }
        public bool Actualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            return contexto.Cliente.ToList();
        }

        public bool Nuevo(Cliente item)
        {
            contexto.Cliente.Add(item);
            contexto.SaveChanges();
            return true;
        }
    }
}
