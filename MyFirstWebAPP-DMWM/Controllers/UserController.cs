using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPP_DMWM.Models;

namespace MyFirstWebAPP_DMWM.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        public UserController(UserManager<ApplicationUser> _usermanager, RoleManager<IdentityRole> _rolemanager)
        {
            this._usermanager = _usermanager;
            this._rolemanager = _rolemanager;
        }
        //Lister tous les utilisateurs de notre application
        public IActionResult Index()
        {
            var users = _usermanager.Users;
            return View(users);
        }
        public IActionResult IndexRoles()
        {
            var roles = _rolemanager.Roles;
            return View(roles);
        }
    }
}
