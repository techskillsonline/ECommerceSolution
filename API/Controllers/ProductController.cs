using Application.IServices;
using Domain.Entities;
using Infrastructure.IRepositories;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;
        private readonly ICategoryService _categoryservice;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService,ICategoryService categoryService, ILogger<ProductController> logger)
        {
            this._productservice = productService;
            this._categoryservice = categoryService;
            this._logger = logger;
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result = this._productservice.AddAsync(product);
            return CreatedAtAction(nameof(Get), new { categoryId = product.Id }, product);
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<IActionResult> Get(int productId)
        {
            var result = await this._productservice.GetAsync(productId);
            return Ok(result.dataObject);
        }

        [HttpGet]
        [Route("[action]/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var result = await this._productservice.GetByCategoryIdAsync(categoryId);
            if(result.isSuccess) 
            {
                return Ok(result.dataObject);
            }
            return NotFound(result.message);
        }
    }
}

