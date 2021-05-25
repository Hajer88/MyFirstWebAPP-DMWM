using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
