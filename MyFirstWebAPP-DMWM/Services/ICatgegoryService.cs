using MyFirstWebAPP_DMWM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPP_DMWM.Services
{
    public interface ICatgegoryService
    {
        Task<IEnumerable<Category>> getallcategories();
    }
}
