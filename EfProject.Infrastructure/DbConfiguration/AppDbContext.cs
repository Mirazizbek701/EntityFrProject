using EfProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace EfProject.Infrastructure.DbConfiguration;

public class AppDbContext : DbContext
{
    public AppDbContext() { }
    public DbSet<Employee> employees { get; set; }
    public DbSet<Project> projects { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Server=::1;Port=5432;Database=proj_employee;User Id=postgres;Password=763m44c44V;");

}
