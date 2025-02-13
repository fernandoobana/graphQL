using Microsoft.AspNetCore.Mvc;
using TestGraphQL.Models;
using TestGraphQL.Repositories;

namespace TestGraphQL.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetAll();

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            await _productRepository.Add(product);
            return Ok();
        }
    }
}
