using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPP_DMWM.Data;

namespace MyFirstWebAPP_DMWM.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        //action result pour lister les catégories
        //HTTP-GET
        public IActionResult Index()
        {
            var cat = _db.Categories.ToList();
            return View(cat);
        }
    }
}
