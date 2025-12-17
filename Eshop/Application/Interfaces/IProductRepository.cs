using Eshop.Domains;

namespace Eshop.Application.Interfaces;
/// <summary>
/// Repository abstraction for working with products.
/// </summary>
public interface IProductRepository
{
    Task<(List<Product>, int)> GetAllAsync(int page, int pageSize);
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task UpdateDescriptionAsync(int id, string description);
}
