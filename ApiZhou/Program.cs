using ApiZhou.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





builder.Services.AddDbContext<GameDbContext>(options =>
{
    options.UseSqlite("Data Source=games.db");
});

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy", policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
    });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("Policy");
// app.UseHttpsRedirection();
app.MapGet("/api/games", async (GameDbContext dbContext) =>
{
    return await dbContext.Games.ToListAsync();
});

app.MapGet("/api/games/{id:int}", async (GameDbContext dbContext, int id) =>
{
    var game = await dbContext.Games.FindAsync(id);
    return game != null ? Results.Ok(game) : Results.NotFound();
});

app.MapGet("/api/games/country/{country}", async (GameDbContext dbContext, string country) =>
{
    return await dbContext.Games
                          .Where(g => g.Country.ToUpper() == country.ToUpper())
                          .ToListAsync();
});

app.MapGet("/api/games/continent/{continent}", async (GameDbContext dbContext, string continent) =>
{
    return await dbContext.Games
                          .Where(g => g.Continent.ToUpper() == continent.ToUpper())
                          .ToListAsync();
});

app.MapGet("/api/games/gender/{gender}", async (GameDbContext dbContext, string gender) =>
{
    return await dbContext.Games
                          .Where(g => g.Gender.ToUpper() == gender.ToUpper())
                          .ToListAsync();
});

app.MapGet("/api/games/count/continent", async (GameDbContext dbContext) =>
{
    return await dbContext.Games
                          .GroupBy(g => g.Continent)
                          .Select(group => new { Continent = group.Key, Count = group.Count() })
                          .OrderByDescending(g => g.Count)
                          .ToListAsync();
});


app.Run();


