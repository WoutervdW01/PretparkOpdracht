using Microsoft.EntityFrameworkCore;
using pretpark.database.models;

namespace pretpark.database;

class DatabaseContext : DbContext
{
    public DbSet<Gebruiker> gebruikers {get; set;}
    public DbSet<Gast> gasten {get; set;}
    public DbSet<Medewerker> medewerkers {get; set;}

    protected override void OnModelCreating(ModelBuilder builer)
    {
        builer.Entity<Gebruiker>().ToTable("Gebruikers");
        builer.Entity<Gast>().ToTable("Gasten");
        builer.Entity<Medewerker>().ToTable("Medewerkers");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        //builder.UseSqlite("Data Source = database.db");
        builder.UseSqlServer("Server = HP-WOUTER;Initial Catalog=YourDatabase;Integrated Security=true");
    }

    public static void Main(string[] args)
    {
        
    }
}