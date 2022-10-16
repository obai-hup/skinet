using Core.Entities;
using System.Collections.Generic;

public interface IProductRepository
{
    Task<Product> GetProductByIdAsync(int id);

    Task<IReadOnlyList<Product>> GetAllProducts();
} 