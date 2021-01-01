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
    public class CategoryService
    {
        CategoryRepository _categoryRepository = new CategoryRepository(new CommonContext());

        public List<CategoryButtonsDTO> GetAllCategoriesButton()
        {
            return _categoryRepository.GetAllCategoriesButton();
        }
    }
}
