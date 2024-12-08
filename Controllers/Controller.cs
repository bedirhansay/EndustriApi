using EndustriApi.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EndustriApi.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(new List<string> { "Category 1", "Category 2", "Category 3" });
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            return Ok(category);
        }
    }

    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new List<string> { "Product 1", "Product 2", "Product 3" });
        }
    }

    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(new List<string> { "Customer 1", "Customer 2", "Customer 3" });
        }
    }

    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(new List<string> { "Order 1", "Order 2", "Order 3" });
        }
    }
}