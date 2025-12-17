using Eshop.Application.Interfaces;
using Eshop.Infrastructure.Repositories;
using Xunit;

public class ProductRepositoryTests
{
    [Fact]
    public async Task GetAll_ReturnsProducts()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();

        // act
        var products = await repository.GetAllAsync();

        // assert
        Assert.NotEmpty(products);
    }

    [Fact]
    public async Task GetById_ReturnsProduct()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();

        // act
        var product = await repository.GetByIdAsync(1);

        // assert
        Assert.Equal(1, product!.Id);
    }

    [Fact]
    public async Task UpdateDescription_ExistingProduct_UpdatesDescription()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();
        var newDescription = "Updated description";

        // act
        await repository.UpdateDescriptionAsync(1, newDescription);
        var updatedProduct = await repository.GetByIdAsync(1);

        // assert
        Assert.NotNull(updatedProduct);
        Assert.Equal(newDescription, updatedProduct.Description);
    }

    [Fact]
    public async Task GetById_UnknownId_ReturnsNull()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();

        // act
        var product = await repository.GetByIdAsync(999999);

        // assert
        Assert.Null(product);
    }
}