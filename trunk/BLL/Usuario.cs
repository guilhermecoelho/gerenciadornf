
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class UsuarioBLL
    {


        public static List<UsuarioTO> listaUsuarioAll()
        {
            return UsuarioDAL.listaUsuarioAll();
        }
        public static UsuarioTO GetUsuarioByID(int ID)
        {
            return UsuarioDAL.GetUsuarioByID(ID);
        }

        public static UsuarioTO GetUsuarioByNomeAndPassword(String strLogin, String strPassword)
        {
            return UsuarioDAL.GetUsuarioByNomeAndPassword(strLogin, strPassword);
        }
        public static void insert(UsuarioTO clsUsuario)
        {
            UsuarioDAL.insert(clsUsuario);
        }
        public static Boolean Delete(UsuarioTO clsUsuario)
        {
            return UsuarioDAL.Delete(clsUsuario);
        }
        public static Boolean Update(UsuarioTO clsUsuario)
        {
            return UsuarioDAL.Update(clsUsuario);
        }
        
    }
}
