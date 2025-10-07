using System;
using System.ComponentModel;
using ModelContextProtocol.Server;
using ServerMCP.Data;
using ServerMCP.Services;

namespace ServerMCP.McpTools;

[McpServerToolType]
public class BeverageTool
{
    private readonly BeverageService _beverageService;
    private readonly ApplicationDbContext _db;

    public BeverageTool(ApplicationDbContext db)
    {
        _db = db;
        _beverageService = new BeverageService(_db);
    }

    [McpServerTool, Description("Get a list of beverages and return as JSON array")]
    public string GetBeveragesJson()
    {
        var task = _beverageService.GetBeveragesJson();
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get a beverage by ID and return as JSON")]
    public string GetBeverageByIdJson([Description("The ID of the beverage to get details for")] int id)
    {
        var task = _beverageService.GetBeverageByIdJson(id);
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get beverages by name and return as JSON")]
    public string GetBeveragesByNameJson([Description("The name of the beverage to filter by")] string name)
    {
        var task = _beverageService.GetBeveragesContainingNameJson(name);
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get beverages by type and return as JSON")]
    public string GetBeveragesByTypeJson([Description("The type of the beverage to filter by")] string type)
    {
        var task = _beverageService.GetBeveragesContainingTypeJson(type);
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get beverages by ingredient and return as JSON")]
    public string GetBeveragesByIngredientJson([Description("The ingredient of the beverage to filter by")] string ingredient)
    {
        var task = _beverageService.GetBeveragesByIngredientJson(ingredient);
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get beverages by calories less than or equal to and return as JSON")]
    public string GetBeveragesByCaloriesLessThanOrEqualJson([Description("The maximum calories per serving to filter by")] int calories)
    {
        var task = _beverageService.GetBeveragesByCaloriesLessThanOrEqualJson(calories);
        return task.GetAwaiter().GetResult();
    }

    [McpServerTool, Description("Get beverages by origin and return as JSON")]
    public string GetBeveragesByOriginJson([Description("The origin of the beverage to filter by")] string origin)
    {
        var task = _beverageService.GetBeveragesByOriginJson(origin);
        return task.GetAwaiter().GetResult();
    }
}
