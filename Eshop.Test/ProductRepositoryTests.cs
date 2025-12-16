using Eshop.Application.Interfaces;
using Eshop.Infrastructure.Repositories;
using Xunit;

public class ProductRepositoryTests
{
    [Fact]
    public void GetAll_ReturnsProducts()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();

        // act
        var products = repository.GetAll();

        // assert
        Assert.NotEmpty(products);
    }

    [Fact]
    public void GetById_ReturnsProduct()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();

        // act
        var product = repository.GetById(1);

        // assert
        Assert.Equal(1, product.Id);
    }

    [Fact]
    public void UpdateDescription_ExistingProduct_UpdatesDescription()
    {
        // arrange
        IProductRepository repository = new MockProductRepository();
        var newDescription = "Updated description";

        // act
        repository.UpdateDescription(1, newDescription);
        var updatedProduct = repository.GetById(1);

        // assert
        Assert.NotNull(updatedProduct);
        Assert.Equal(newDescription, updatedProduct.Description);
    }

    [Fact]
    public void GetById_UnknownId_ReturnsNull()
    {
        IProductRepository repository = new MockProductRepository();

        var product = repository.GetById(999999);

        Assert.Null(product);
    }
}