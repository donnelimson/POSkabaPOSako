using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ItemMasterListboxMainPOS
    {
        public int Id { get; set; }
        public string LongDescription { get; set; }
        public int Quantity { get; set; }
        public int Index { get; set; }
    }
    public class ItemMasterButtonsDTO
    {
        public int Id { get; set; }
        public string LongDescription { get; set; }
    }
}
