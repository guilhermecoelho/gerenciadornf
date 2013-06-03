using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item;

namespace Item
{
    public class ItemBLL
    {
        public static List<ItemTO> listaItemAll()
        {
            return ItemDAL.listaItemAll();
        }
        public static ItemTO GetItemByID(int ID)
        {
            return ItemDAL.GetItemByID(ID);
        }
        public static void insert(ItemTO clsItem)
        {
            ItemDAL.insert(clsItem);
        }
        public static Boolean Delete(ItemTO clsItem)
        {
            return ItemDAL.Delete(clsItem);
        }
        public static Boolean Update(ItemTO clsItem)
        {
            return ItemDAL.Update(clsItem);
        }
        
    }
}
