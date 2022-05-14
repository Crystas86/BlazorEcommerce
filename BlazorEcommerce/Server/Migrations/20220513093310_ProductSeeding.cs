using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Lenovo Legion T5: een krachtpatser van de nieuwste generatie. Met de Lenovo Legion T5 haalt u een echte gaming krachtpatser in huis. De nieuwste AMD Ryzen 7 processor heeft een turbo kloksnelheid van 4,6 Ghz en maar liefst 8 cores en 16 threads. In combinatie met het werkgeheugen van 16 GB en de snelle 1 TB SSD zorgt dit voor krachtige prestaties. Zo kunt u niet alleen genieten van de nieuwste games, maar is deze desktop ook uiterst geschikt voor taken als rendering, 3D tekenen en foto- en of videobewerking.", "https://www.megekko.nl/productimg/310442/midi/1_Lenovo-Legion-T5-26AMR5-AMD-Ryzen-7-5800-RTX3070-Desktop-Gaming-PC.jpg", 999.00m, "Lenovo Legion T5 26AMR5 AMD Ryzen 7 5800 RTX3070 Desktop Gaming PC" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Deze ScreenON GamePC set is perfect voor de startende gamer. De computer heeft geen losse videokaart maar maakt slim gebruik van een processor met geïntegreerde videochip.", "https://media.s-bol.com/qMyERAG68o5k/l51OyMM/550x550.jpg", 2.00m, "ScreenON - Gaming Set" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Brute kracht en een ongeëvenaarde snelheid komen samen in de Legion Tower 5.", "https://media.s-bol.com/9pPMv1ApXVRZ/g56q9Xl/550x481.jpg", 3.00m, "Lenovo Legion T5" });
        }

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
        }
    }
}
