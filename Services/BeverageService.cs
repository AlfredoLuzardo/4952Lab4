using System;
using Microsoft.EntityFrameworkCore;
using ServerMCP.Data;

namespace ServerMCP.Services;

public class BeverageService(ApplicationDbContext db) {
  public async Task<string> GetBeveragesJson() {
    var beverages = await db.Beverages.ToListAsync();
    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }

  public async Task<string> GetBeverageByIdJson(int id) {
    var beverage = await db.Beverages.FindAsync(id);
    return System.Text.Json.JsonSerializer.Serialize(beverage);
  }

  public async Task<string> GetBeveragesContainingNameJson(string name) {
    var beverages = await db.Beverages
      .Where(b => b.Name!.Contains(name))
      .ToListAsync();

    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }


  public async Task<string> GetBeveragesContainingTypeJson(string type) {
    var beverages = await db.Beverages
      .Where(b => b.Type!.Contains(type))
      .ToListAsync();

    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }

  public async Task<string> GetBeveragesByIngredientJson(string ingredient) {
    var beverages = await db.Beverages
      .Where(b => b.MainIngredient!.Contains(ingredient))
      .ToListAsync();

    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }

  public async Task<string> GetBeveragesByCaloriesLessThanOrEqualJson(int calories) {
    var beverages = await db.Beverages
      .Where(b => b.CaloriesPerServing <= calories)
      .ToListAsync();

    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }

  public async Task<string> GetBeveragesByOriginJson(string origin) {
    var beverages = await db.Beverages
      .Where(b => b.Origin!.Contains(origin))
      .ToListAsync();

    return System.Text.Json.JsonSerializer.Serialize(beverages);
  }
}