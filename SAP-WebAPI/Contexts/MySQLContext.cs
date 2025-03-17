using System;
using Microsoft.EntityFrameworkCore;
using SAP_WebAPI.Models;

namespace SAP_WebAPI.Contexts;

public class MySQLContext : DbContext
{

    static readonly string connectionString = "Server=localhost; User ID=root; Password=kzl; Database=sap_website";

    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(e => e.Roles)
        .WithMany();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
