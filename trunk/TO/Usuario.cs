using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    [Serializable]
    public class UsuarioTO
    {
        public int ID { get; set; }
        public String Password { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public int IDTipoUsuario { get; set; }
    }
}
