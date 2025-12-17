using Eshop.Application.Interfaces;
using Eshop.Domains;
using Eshop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories;

public class EfProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public EfProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<(List<Product>, int)> GetAllAsync(int page, int pageSize)
    {
        var products = await _context.Products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync();

        var productCount = await _context.Products
            .CountAsync();

        return (products, productCount);
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task UpdateDescriptionAsync(int id, string description)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return;

        product.Description = description;
        await _context.SaveChangesAsync();
    }
}
