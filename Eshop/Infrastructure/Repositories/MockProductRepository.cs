using Eshop.Application.Interfaces;
using Eshop.Domains;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories;

public class MockProductRepository : IProductRepository
{
    private readonly List<Product> _products =
    [
        new Product
        {
            Id = 1,
            Name = "Hrnec A",
            ImgUrl = "https://mujeshop.cz/A.jpg",
            Price = 519.90m,
            Description = "Mock Hrnec A"
        },
        new Product
        {
            Id = 2,
            Name = "Vařečka B",
            ImgUrl = "https://mujeshop.cz/B.jpg",
            Price = 99.90m,
            Description = "Mock Vařečka B"
        },
        new Product
        {
            Id = 3,
            Name = "Sklenice C",
            ImgUrl = "https://mujeshop.cz/C.jpg",
            Price = 150.00m,
            Description = "Mock Sklenice C"
        },
        new Product
        {
            Id = 4,
            Name = "Talíř D",
            ImgUrl = "https://mujeshop.cz/D.jpg",
            Price = 189.90m,
            Description = "Mock Talíř D"
        }
    ];

    public Task<List<Product>> GetAllAsync()
    {
        return Task.FromResult(_products);
    }

    public Task<(List<Product>, int)> GetAllAsync(int page, int pageSize)
    {
        var products = _products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        var productCount = _products.Count;

        return Task.FromResult((products, productCount));
    }

    public Task <Product?> GetByIdAsync(int id) =>
        Task.FromResult(_products.FirstOrDefault(p => p.Id == id));

    public async Task UpdateDescriptionAsync(int id, string description)
    {
        var product = await GetByIdAsync(id);
        if (product != null)
            product.Description = description;
    }
}

