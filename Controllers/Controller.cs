using EndustriApi.Entity;
using EndustriApi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EndustriApi.Controllers
{

    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            return Ok(category);
        }
    }
}