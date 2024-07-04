using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using LibraryZhou;
using Microsoft.EntityFrameworkCore;

namespace ApiZhou.Data;

    public class GameDbContext : DbContext
{
    public DbSet<Game> Games { get; set; }

    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define GameId as the primary key
        modelBuilder.Entity<Game>()
                    .HasKey(g => g.GameId);

        // Configure GameId to auto-increment
        modelBuilder.Entity<Game>()
                    .Property(g => g.GameId)
                    .ValueGeneratedOnAdd();

        // Seed data from CSV file
        modelBuilder.Entity<Game>().HasData(GetGames().ToArray());
    }

    // Method to seed the database from CSV
    private static IEnumerable<Game> GetGames()
    {
        string[] path = { Directory.GetCurrentDirectory(), "wwwroot", "fifa-world-cup.csv" };
        string csvFilePath = Path.Combine(path);
        
        var config = new CsvConfiguration(CultureInfo.InvariantCulture) 
        { 
            Encoding = System.Text.Encoding.UTF8, 
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, config))
        {
            var games = csv.GetRecords<Game>().ToList();
            // Assuming the CSV doesn't have an ID and we need to assign one manually
            int id = 1;
            foreach (var game in games)
            {
                game.GameId = id++;
            }
            return games;
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Here we configure the SQLite database
        optionsBuilder.UseSqlite("Data Source=games.db");
    }
}