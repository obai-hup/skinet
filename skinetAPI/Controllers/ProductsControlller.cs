using Microsoft.AspNetCore.Mvc;

namespace skinetAPI.Controllers;

[ApiController]
[Route("api/{controller}")]
public class ProductsControlller : ControllerBase
{
    // GET ALL Products
    [HttpGet]
    public string GetProducts()
    {
        return "Get Product";
    }
    
    // GET One Product
    [HttpGet("{id}")]
    public string GetProduct(string id)
    {
        return id;
    }
    
}