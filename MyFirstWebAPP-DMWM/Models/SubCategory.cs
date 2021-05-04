using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Models
{
    public class SubCategory
    {
        //EF Conventions Vs EF annotations
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Name of SubCategory")]
        public string Name { get; set; }
        public Category category { get; set; }
    }
}
