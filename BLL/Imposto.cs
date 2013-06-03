using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto;

namespace Imposto
{
    public class ImpostoBLL
    {
        public static List<ImpostoTO> listaImpostoAll()
        {
            return ImpostoDAL.listaImpostoAll();
        }
        public static ImpostoTO GetImpostoByID(int ID)
        {
            return ImpostoDAL.GetImpostoByID(ID);
        }
        public static void insert(ImpostoTO clsImposto)
        {
            ImpostoDAL.insert(clsImposto);
        }
        public static Boolean Delete(ImpostoTO clsImposto)
        {
            return ImpostoDAL.Delete(clsImposto);
        }
        public static Boolean Update(ImpostoTO clsImposto)
        {
            return ImpostoDAL.Update(clsImposto);
        }
        
    }
}
