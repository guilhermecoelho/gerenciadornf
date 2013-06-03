using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item
{
    [Serializable]
    public class ItemTO
    {
        public int IDItem{get; set;}
        public String Nome{get; set;}
        public String Descricao{get; set;}
    }
}
