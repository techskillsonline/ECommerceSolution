using Application.IServices;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ICategoryService categoryService,ILogger<CategoryController> logger)
        {
            this._categoryservice = categoryService;
            this._logger = logger;
        }

        [HttpPost]
        public IActionResult Post(Category category) 
        {
            var result = this._categoryservice.AddAsync(category);
            return CreatedAtAction(nameof(Get), new { categoryId = category.Id },category);
        }

        [HttpGet]
        [Route("{categoryId}")]
        public async Task<IActionResult> Get(int categoryId)
        {
            var result = await this._categoryservice.GetAsync(categoryId);
            return Ok(result.dataObject);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var obj =  await this._categoryservice.GetAllAsync();
            if(!obj.isSuccess)
            {
                return NotFound(obj.message);
            }
            return Ok(obj.dataObject);
        }
    }
}


