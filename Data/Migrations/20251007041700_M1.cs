using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerMCP.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    BeverageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    MainIngredient = table.Column<string>(type: "TEXT", nullable: true),
                    Origin = table.Column<string>(type: "TEXT", nullable: true),
                    CaloriesPerServing = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.BeverageId);
                });

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "BeverageId", "CaloriesPerServing", "MainIngredient", "Name", "Origin", "Type" },
                values: new object[,]
                {
                    { 1, 140, "Sugar", "Coca-Cola", "United States", "Soft Drink" },
                    { 2, 150, "Sugar", "Pepsi", "United States", "Soft Drink" },
                    { 3, 0, "Green Tea Leaves", "Green Tea", "China", "Tea" },
                    { 4, 5, "Coffee Beans", "Espresso", "Italy", "Coffee" },
                    { 5, 250, "Fruit", "Smoothie", "United States", "Fruit Drink" },
                    { 6, 245, "Coconut Cream", "Pina Colada", "Puerto Rico", "Cocktail" },
                    { 7, 120, "Lemon", "Lemonade", "Ancient Egypt", "Soft Drink" },
                    { 8, 350, "Milk", "Milkshake", "United States", "Dairy Drink" },
                    { 9, 150, "Black Tea Leaves and Spices", "Chai", "India", "Tea" },
                    { 10, 200, "Tequila", "Margarita", "Mexico", "Cocktail" },
                    { 11, 200, "Matcha Powder", "Matcha Latte", "Japan", "Tea" },
                    { 12, 0, "Carbonated Water", "Sparkling Water", "Various", "Water" },
                    { 13, 30, "Tea and Sugar", "Kombucha", "China", "Fermented Tea" },
                    { 14, 200, "Cocoa Beans", "Hot Chocolate", "South America", "Hot Drink" },
                    { 15, 125, "Grapes", "Red Wine", "Various", "Alcoholic Drink" },
                    { 16, 150, "Rum", "Mojito", "Cuba", "Cocktail" },
                    { 17, 120, "Ginger", "Ginger Ale", "United States", "Soft Drink" },
                    { 18, 5, "Coffee Beans", "Black Coffee", "Ethiopia", "Coffee" },
                    { 19, 0, "Chamomile Flowers", "Chamomile Tea", "Egypt", "Herbal Tea" },
                    { 20, 100, "Grain", "Whiskey", "Ireland/Scotland", "Alcoholic Drink" },
                    { 21, 60, "Coconut", "Coconut Water", "Pacific Islands", "Water" },
                    { 22, 160, "Sarsaparilla Root", "Root Beer", "United States", "Soft Drink" },
                    { 23, 90, "Black Tea Leaves", "Iced Tea", "United States", "Cold Tea" },
                    { 24, 190, "Coffee and Milk", "Latte", "Italy", "Coffee" },
                    { 25, 0, "Various Herbs", "Herbal Tea", "Worldwide", "Tea" },
                    { 26, 110, "Caffeine and Sugar", "Energy Drink", "Worldwide", "Soft Drink" },
                    { 27, 150, "Barley and Hops", "Beer", "Various", "Alcoholic Drink" },
                    { 28, 180, "Red Wine and Fruit", "Sangria", "Spain", "Alcoholic Drink" },
                    { 29, 60, "Milk or Plant-Based", "Probiotic Drink", "Worldwide", "Fermented Drink" },
                    { 30, 200, "Tea and Tapioca Pearls", "Bubble Tea", "Taiwan", "Tea" },
                    { 31, 210, "Apples", "Cider", "United Kingdom", "Alcoholic Drink" },
                    { 32, 130, "Quinine and Sugar", "Tonic Water", "United Kingdom", "Soft Drink" },
                    { 33, 2, "Coffee Beans (Decaffeinated)", "Decaf Coffee", "Worldwide", "Coffee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beverages");
        }
    }
}
