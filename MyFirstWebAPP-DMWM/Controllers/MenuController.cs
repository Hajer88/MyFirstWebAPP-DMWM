using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPP_DMWM.Data;
using MyFirstWebAPP_DMWM.Models;

namespace MyFirstWebAPP_DMWM.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _usermanager;
        public MenuController(ApplicationDbContext _db, UserManager<ApplicationUser> _usermanager)
        {
            this._db = _db;
            this._usermanager = _usermanager;
        }
        public IActionResult MenuListByUser()
        {
            var currentuser = _usermanager.GetUserId(User);
            var menus = _db.menuLists.Where(x => x.UserId == currentuser)
                .ToList();
            return View(menus);
        }
    }
}
