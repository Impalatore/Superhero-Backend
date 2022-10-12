using Microsoft.EntityFrameworkCore;

namespace Superhero_Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
}