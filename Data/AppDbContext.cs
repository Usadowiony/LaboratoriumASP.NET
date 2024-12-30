using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext 
{ 
    public DbSet<ContactEntity> Contacts { get; set; }
    public DbSet<OrganizationEntity> Organizations { get; set; }
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
        modelBuilder.Entity<OrganizationEntity>()
            .ToTable("Organizations")
            .HasData(
                new OrganizationEntity()
                {
                    Id = 101,
                    NIP = "672116274",
                    Name = "Udex",
                    REGON = "672116274",
                },
                new OrganizationEntity()
                {
                    Id = 102,
                    NIP = "672456274",
                    Name = "Madex",
                    REGON = "672456274"
                }
            );
        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(o => o.Adress)
            .HasData(
                new {OrganizationEntityId = 101, Street = "Wieliczka",City = "Kraków"},
                new{OrganizationEntityId = 102, Street = "Kazimierz", City= "Kraków"}
            );
        modelBuilder.Entity<ContactEntity>()
            .Property(c => c.OrganizationId)
            .HasDefaultValue(101);
        modelBuilder.Entity<ContactEntity>()
            .HasData(new ContactEntity
            {
                Id = 1,
                FirstName = "Adam",
                Email = "adam@wsei.edu.pl",
                PhoneNumber = "127813268163",
                BirthDate = new DateTime(2000, 10, 10),
                Created = DateTime.Now,
                OrganizationId = 101,
            },new ContactEntity
            {
                Id = 2,
                Email = "ewa@wsei.edu.pl",
                PhoneNumber = "293443823478",
                BirthDate = new DateTime(1999, 8, 10),
                Created = DateTime.Now,
                OrganizationId = 101,
            });
    }
} 