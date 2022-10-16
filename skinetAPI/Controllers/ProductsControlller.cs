using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace skinetAPI.Controllers;

[ApiController]
[Route("api/{controller}")]
public class ProductsControlller : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductsControlller(IProductRepository repository)
    {
       _repository = repository;
    }
    // GET ALL Products
    [HttpGet]
    public async Task<IEnumerable<Product>> GetProducts()
    {
        var products = await _repository.GetAllProducts();
        return products;
    }
    
    // GET One Product
    [HttpGet("{id}")]
    public async Task<Product> GetProduct(int id)
    {
        return await _repository.GetProductByIdAsync(id);
    }
    
}