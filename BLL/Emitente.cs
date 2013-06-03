using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emitente;

namespace Emitente
{
    public class EmitenteBLL
    {
        public static List<EmitenteTO> listaEmitenteAll()
        {
            return EmitenteDAL.listaEmitenteAll();
        }
        public static EmitenteTO GetEmitenteByID(int ID)
        {
            return EmitenteDAL.GetEmitenteByID(ID);
        }
        public static void insert(EmitenteTO clsEmitente)
        {
            EmitenteDAL.insert(clsEmitente);
        }
        public static Boolean Delete(EmitenteTO clsEmitente)
        {
            return EmitenteDAL.Delete(clsEmitente);
        }
        public static Boolean Update(EmitenteTO clsEmitente)
        {
            return EmitenteDAL.Update(clsEmitente);
        }
    }
}
