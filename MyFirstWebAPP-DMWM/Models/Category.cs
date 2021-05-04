using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name="Name of Category")]
        [Required]
        public string Name { get; set; }
        
        
    }
}
