using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoUsuario
{
    [Serializable]
    public class TipoUsuarioTO
    {
        public int IDTipoUsuario{get; set;}
        public String Tipo{get; set;}
    }
}
