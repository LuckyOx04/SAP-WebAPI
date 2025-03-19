using System;
using Microsoft.EntityFrameworkCore;
using SAP_WebAPI.Models;

namespace SAP_WebAPI.Contexts;

public class MySQLContext : DbContext
{
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<User> Users { get; set; }

    public MySQLContext(DbContextOptions<MySQLContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(e => e.Roles)
        .WithMany();
    }
}
