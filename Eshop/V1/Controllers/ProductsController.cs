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
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPatch("{id:int}/description")]
    public async Task<ActionResult<IEnumerable<Product>>> UpdateDescription(
    int id,
    [FromBody] UpdateProductDescriptionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Description))
            return BadRequest("Description cannot be empty.");

        var product = await _repository.GetByIdAsync(id);
        if (product is null)
            return NotFound();

        await _repository.UpdateDescriptionAsync(id, request.Description);

        return Ok(product);
    }
}