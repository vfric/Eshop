using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Eshop.Models;

namespace Eshop.V1.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    // MOCK DATA
    private static readonly List<Product> Products =
    [
        new Product
        {
            Id = 1,
            Name = "Product A",
            ImgUrl = "https://example.com/a.jpg",
            Price = 199.90m,
            Description = "First test product"
        },
        new Product
        {
            Id = 2,
            Name = "Product B",
            ImgUrl = "https://example.com/b.jpg",
            Price = 299.90m,
            Description = "Second test product"
        }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(Products);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }
}
