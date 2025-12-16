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

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.AsNoTracking().ToList();
    }

    public Product? GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public void UpdateDescription(int id, string description)
    {
        var product = _context.Products.Find(id);
        if (product == null)
            return;

        product.Description = description;
        _context.SaveChanges();
    }
}
