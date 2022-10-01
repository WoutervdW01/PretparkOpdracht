using Microsoft.EntityFrameworkCore;

class Gebruiker
{
    public int Id{get; set;}
    public string Email{get; set;}
}

class DatabaseContext : DbContext
{
    public DbSet<Gebruiker> gebruikers {get; set;}

    protected override void OnModelCreating(ModelBuilder builer)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlite("Data Source = database.db");
    }

    public static void Main(string[] args)
    {
        
    }
}