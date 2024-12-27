using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext 
{ 
    public DbSet<ContactEntity> Contacts { get; set; } 
    private string DbPath { get; set; } 
    public AppDbContext() 
    { 
        var folder = Environment.SpecialFolder.LocalApplicationData; 
        var path = Environment.GetFolderPath(folder); 
        DbPath = System.IO.Path.Join(path, "contacts.db"); 
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactEntity>().HasData(
            new ContactEntity()
            {
                Id = 1,
                FirstName = "Adam",
                Email = "adam@wsei.edu.pl",
                PhoneNumber = "127813268163",
                BirthDate = new DateTime(2000, 10, 10)
            },
            new ContactEntity()
            {
                Id = 2,
                Email = "ewa@wsei.edu.pl",
                PhoneNumber = "293443823478",
                BirthDate = new DateTime(1999, 8, 10)
            }
        );
    }
} 