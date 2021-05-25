using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Models
{
    public class MenuListbyUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public bool approved { get; set; }
    }
}
