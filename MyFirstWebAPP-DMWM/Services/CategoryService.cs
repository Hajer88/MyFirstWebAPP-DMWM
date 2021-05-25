using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyFirstWebAPP_DMWM.Data;
using MyFirstWebAPP_DMWM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Services
{
    public class CategoryService : ICatgegoryService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper _imapper;
        public CategoryService(ApplicationDbContext _db, IMapper _imapper)
        {
            db = _db;
            this._imapper = _imapper;
        }
        public async Task<IEnumerable<CategoryDTO>> getallcategories()
        {
            var cat = await db.Categories.ToListAsync();
            var catDTO = _imapper.Map<List<CategoryDTO>>(cat);
            //var catDTO = from c in db.Categories
            //             select new CategoryDTO()
            //             {
            //                    Id=c.Id,
            //                    Name=c.Name,
            //             };
            return catDTO;
        }

        public async Task<CategoryDTO> CreateCategory(CategoryDTO category)
        {
            var cat = _imapper.Map<Category>(category);
            db.Categories.Add(cat);
            await db.SaveChangesAsync();
            return _imapper.Map<Category,CategoryDTO>(cat);
        }
        public async Task<CategoryDTO> EditCategory(int id, Category category)
        {
            var CatInDb = await db.Categories.FindAsync(id);
            CatInDb.Name = category.Name;
            await db.SaveChangesAsync();
            return _imapper.Map<Category,CategoryDTO>(category);
        }
        public async Task<Category> DeleteCategory(int id)
        {
            var CatInDb = await db.Categories.FindAsync(id);
            db.Remove(CatInDb);
            await db.SaveChangesAsync();
            return CatInDb;
        }
        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategoryName()
        {
            var subcate = await db.Subcategories.Include(c => c.category)
                .Where(c => c.category.Name == "Cat 3")
                .ToListAsync();
            return subcate;
        }



    }
}
