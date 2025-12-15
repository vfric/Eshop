using Eshop.Domains;

namespace Eshop.V2.Models;

public class PagedProductsResponse
{
    public IEnumerable<Product> Items { get; init; } = [];
    public int Page { get; init; }
    public int PageSize { get; init; }
    public int TotalCount { get; init; }
}
