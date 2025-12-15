using Asp.Versioning;
using Eshop.Application.Interfaces;
using Eshop.Domains;
using Eshop.V1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.V1.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _repository.GetById(id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPatch("{id:int}/description")]
    public IActionResult UpdateDescription(
    int id,
    [FromBody] UpdateProductDescriptionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Description))
            return BadRequest("Description cannot be empty.");

        var product = _repository.GetById(id);
        if (product is null)
            return NotFound();

        _repository.UpdateDescription(id, request.Description);

        return NoContent();
    }
}