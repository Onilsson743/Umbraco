using CritoProject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CritoProject.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public required DbSet<ContactFormEntity> ContactForm { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<ContactFormEntity>(entity =>
        {
            entity.ToTable("contactFormData");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.Name).HasColumnName("Name");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");            
        });
}
