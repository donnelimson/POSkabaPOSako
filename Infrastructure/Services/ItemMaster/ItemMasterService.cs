using Context;
using Infrastructure.Repositories;
using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.ItemMasterService
{
    public class ItemMasterService
    {
        ItemMasterRepository _itemMasterRepository = new ItemMasterRepository(new CommonContext());
      
        public ItemMaster GetItemMasterByBarcode(string barcode)
        {
            return _itemMasterRepository.GetItemMasterByBarcode(barcode);
        }
        public List<ItemMasterButtonsDTO> GetAllItemMasterButtons(int categoryId)
        {
            return _itemMasterRepository.GetAllItemMasterButtons(categoryId);
        }
    }
}
