using ConsoleApp1;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp1;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Book> Books => Set<Book>();
    public ApplicationContext() => Database.EnsureCreated();
    
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=library.db");
    }
}