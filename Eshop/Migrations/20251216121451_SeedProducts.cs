using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eshop.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Kvalitní nerezový hrnec pro každodenní vaření.", "https://mujeshop.cz/hrnec-a.jpg", "Hrnec A", 519.90m },
                    { 2, "Dřevěná vařečka vhodná na všechny povrchy.", "https://mujeshop.cz/varecka-b.jpg", "Vařečka B", 99.90m },
                    { 3, "Nepřilnavá pánev ideální na smažení.", "https://mujeshop.cz/panev-c.jpg", "Pánev C", 899.00m },
                    { 4, "Skleněná poklice s odvětráváním.", "https://mujeshop.cz/poklice-d.jpg", "Poklice D", 199.00m },
                    { 5, "Velký hrnec vhodný na polévky a vývary.", "https://mujeshop.cz/hrnec-e.jpg", "Hrnec E", 749.00m },
                    { 6, "Sada ostrých kuchyňských nožů.", "https://mujeshop.cz/noze-f.jpg", "Sada nožů F", 1299.00m },
                    { 7, "Dřevěné krájecí prkénko.", "https://mujeshop.cz/prkenko-g.jpg", "Prkénko G", 149.90m },
                    { 8, "Menší rendlík ideální na omáčky.", "https://mujeshop.cz/rendlik-h.jpg", "Rendlík H", 459.00m },
                    { 9, "Kovový cedník na těstoviny.", "https://mujeshop.cz/cednik-i.jpg", "Cedník I", 179.00m },
                    { 10, "Kuchyňská mísa na míchání.", "https://mujeshop.cz/misa-j.jpg", "Mísa J", 249.00m },
                    { 11, "Víceúčelové struhadlo z nerezu.", "https://mujeshop.cz/struhadlo-k.jpg", "Struhadlo K", 199.90m },
                    { 12, "Kuchyňská naběračka na polévku.", "https://mujeshop.cz/lzice-l.jpg", "Lžíce L", 89.90m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
