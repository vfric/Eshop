using Asp.Versioning;
using Eshop.Application.Interfaces;
using Eshop.V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.V2.Controllers;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<PagedProductsResponse>> GetAll(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10)
    {
        if (page <= 0 || pageSize <= 0)
            return BadRequest("Page and pageSize must be greater than zero.");

        var (pagedProducts,totalCount) = await _repository.GetAllAsync(page, pageSize);


        var response = new PagedProductsResponse
        {
            Items = pagedProducts,
            Page = page,
            PageSize = pageSize,
            TotalCount = totalCount
        };

        return Ok(response);
    }
}
