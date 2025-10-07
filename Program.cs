using Microsoft.EntityFrameworkCore;
using ServerMCP.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
  options.AddPolicy("ClientOrigins", policy =>
    policy.WithOrigins(
        "http://localhost:5075", 
        "http://localhost:5197",
        "https://alfredoapp-abgzh4gjcvhxgfen.canadacentral-01.azurewebsites.net") // replace with your client URL(s)
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials()
  );
});

builder.Services.AddMcpServer()
.WithHttpTransport()
.WithToolsFromAssembly();

var connStr = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    
builder.Services.AddDbContext<ApplicationDbContext>(
	option => option.UseSqlite(connStr)
);

var app = builder.Build();

app.UseCors("ClientOrigins");

// Add MCP Middleware
app.MapMcp();

// Apply database migrations on startup
using (var scope = app.Services.CreateScope()) {
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApplicationDbContext>();    
    context.Database.Migrate();
}

app.Run();
