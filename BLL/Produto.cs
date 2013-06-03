using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produto;

namespace Produto
{
    public class ProdutoBLL
    {
        public static List<ProdutoTO> listaProdutoAll()
        {
            return ProdutoDAL.listaProdutoAll();
        }
        public static ProdutoTO GetProdutoByID(int ID)
        {
            return ProdutoDAL.GetProdutoByID(ID);
        }
        public static void insert(ProdutoTO clsProduto)
        {
            ProdutoDAL.insert(clsProduto);
        }
        public static Boolean Delete(ProdutoTO clsProduto)
        {
            return ProdutoDAL.Delete(clsProduto);
        }
        public static Boolean Update(ProdutoTO clsProduto)
        {
            return ProdutoDAL.Update(clsProduto);
        }
        
    }
}
