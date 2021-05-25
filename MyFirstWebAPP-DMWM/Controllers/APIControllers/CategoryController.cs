using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPP_DMWM.Models;
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
        [HttpPost]
        public async Task<IActionResult> CreateCategorie(CategoryDTO category)
        {
            var categorie = await icatgegoryService.CreateCategory(category);
            return Ok(categorie);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditCategorie(int id, Category category)
        {
            if (!ModelState.IsValid) return BadRequest();
            var categorie = await icatgegoryService.EditCategory(id,category);
            return Ok(categorie);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {
           
            var categorie = await icatgegoryService.DeleteCategory(id);
            return Ok(categorie);
        }
        [HttpGet("subcate")]
        public async Task<IActionResult> GetSubCategorie()
        {

            var categorie = await icatgegoryService.GetSubCategoriesByCategoryName();
            return Ok(categorie);
        }


    }
}
