using CritoProject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CritoProject.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<ContactFormEntity> ContactForm { get; set; }
    public DbSet<SignUpEntity> Subscribers { get; set; }

}
