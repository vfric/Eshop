using Eshop.Domains;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Hrnec A",
                ImgUrl = "https://mujeshop.cz/hrnec-a.jpg",
                Price = 519.90m,
                Description = "Kvalitní nerezový hrnec pro každodenní vaření."
            },
            new Product
            {
                Id = 2,
                Name = "Vařečka B",
                ImgUrl = "https://mujeshop.cz/varecka-b.jpg",
                Price = 99.90m,
                Description = "Dřevěná vařečka vhodná na všechny povrchy."
            },
            new Product
            {
                Id = 3,
                Name = "Pánev C",
                ImgUrl = "https://mujeshop.cz/panev-c.jpg",
                Price = 899.00m,
                Description = "Nepřilnavá pánev ideální na smažení."
            },
            new Product
            {
                Id = 4,
                Name = "Poklice D",
                ImgUrl = "https://mujeshop.cz/poklice-d.jpg",
                Price = 199.00m,
                Description = "Skleněná poklice s odvětráváním."
            },
            new Product
            {
                Id = 5,
                Name = "Hrnec E",
                ImgUrl = "https://mujeshop.cz/hrnec-e.jpg",
                Price = 749.00m,
                Description = "Velký hrnec vhodný na polévky a vývary."
            },
            new Product
            {
                Id = 6,
                Name = "Sada nožů F",
                ImgUrl = "https://mujeshop.cz/noze-f.jpg",
                Price = 1299.00m,
                Description = "Sada ostrých kuchyňských nožů."
            },
            new Product
            {
                Id = 7,
                Name = "Prkénko G",
                ImgUrl = "https://mujeshop.cz/prkenko-g.jpg",
                Price = 149.90m,
                Description = "Dřevěné krájecí prkénko."
            },
            new Product
            {
                Id = 8,
                Name = "Rendlík H",
                ImgUrl = "https://mujeshop.cz/rendlik-h.jpg",
                Price = 459.00m,
                Description = "Menší rendlík ideální na omáčky."
            },
            new Product
            {
                Id = 9,
                Name = "Cedník I",
                ImgUrl = "https://mujeshop.cz/cednik-i.jpg",
                Price = 179.00m,
                Description = "Kovový cedník na těstoviny."
            },
            new Product
            {
                Id = 10,
                Name = "Mísa J",
                ImgUrl = "https://mujeshop.cz/misa-j.jpg",
                Price = 249.00m,
                Description = "Kuchyňská mísa na míchání."
            },
            new Product
            {
                Id = 11,
                Name = "Struhadlo K",
                ImgUrl = "https://mujeshop.cz/struhadlo-k.jpg",
                Price = 199.90m,
                Description = "Víceúčelové struhadlo z nerezu."
            },
            new Product
            {
                Id = 12,
                Name = "Lžíce L",
                ImgUrl = "https://mujeshop.cz/lzice-l.jpg",
                Price = 89.90m,
                Description = "Kuchyňská naběračka na polévku."
            }
        );
    }
}
