using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoUsuario;

namespace TipoUsuario
{
    public class TipoUsuarioBLL
    {
        public static List<TipoUsuarioTO> listaTipoUsuario()
        {
            List<TipoUsuarioTO> clsTipoUsuario = new List<TipoUsuarioTO>();
            clsTipoUsuario = TipoUsuarioDAL.listaTipoUsuario();
            return clsTipoUsuario;
        }
    }
}
