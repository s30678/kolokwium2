using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DataBaseContext: DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character_title> Character_titles { get; set; }

    protected DataBaseContext()
    {
    }

    public DataBaseContext(DbContextOptions options){
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
        new Item
        {
            ItemId = 1,
            Name = "macio",
            Weight = 100
        } 
            );
        base.OnModelCreating(modelBuilder);
        
    }

}
