using Eshop.Domains;

namespace Eshop.Application.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product? GetById(int id);
    void UpdateDescription(int id, string description);
}
