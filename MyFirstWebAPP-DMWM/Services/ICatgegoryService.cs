using MyFirstWebAPP_DMWM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Services
{
    public interface ICatgegoryService
    {
        Task<IEnumerable<CategoryDTO>> getallcategories();
        Task<CategoryDTO> CreateCategory(CategoryDTO category);
        Task<CategoryDTO> EditCategory(int id, Category category);
        Task<Category> DeleteCategory(int id);
        Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryName();

    }
}
