using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPP_DMWM.Services;

namespace MyFirstWebAPP_DMWM.Controllers.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatgegoryService icatgegoryService;
        public CategoryController(ICatgegoryService icatgegoryService)
        {
            this.icatgegoryService = icatgegoryService;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> getCategories()
        {
            var categories = await icatgegoryService.getallcategories();
            return Ok(categories);
        }
    }
}
