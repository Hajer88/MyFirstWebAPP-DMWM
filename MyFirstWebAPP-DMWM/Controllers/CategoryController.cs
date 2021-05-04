using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstWebAPP_DMWM.Data;
using MyFirstWebAPP_DMWM.Models;

namespace MyFirstWebAPP_DMWM.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            //_db=new ApplicationDbContext();
            _db = db;
        }
        //action result pour lister les catégories
        //HTTP-GET
        public async Task<IActionResult> Index()
        {
            var cat = await _db.Categories.ToListAsync();
            return View(cat);
        }
        //HTTP-GET 
        public IActionResult Create()
        {
            return View();
        }
        //HTTP-POST
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index","Category");
            }
            return View(category);

        }
        //HTTP-GET
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var category = _db.Categories.SingleOrDefault(c=>c.Id==id);
            return View(category);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
           // var catInDb = _db.Categories.Find(id);
           //if (id == null) return Content("Id not found");
            //Mapping manuelle
            _db.Update(category);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
            
            
        }

    }
}
