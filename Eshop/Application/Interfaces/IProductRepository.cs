using Eshop.Domains;

namespace Eshop.Application.Interfaces;
/// <summary>
/// Repository abstraction for working with products.
/// </summary>
public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product? GetById(int id);
    void UpdateDescription(int id, string description);
}
