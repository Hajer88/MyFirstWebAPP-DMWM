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
        public CategoryService(ApplicationDbContext _db)
        {
            db = _db;
        }
        public async Task<IEnumerable<Category>> getallcategories()
        {
            return await db.Categories.ToListAsync();
        }
    }
}
