using Domain.Entities;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PublicDbContext : DbContext
{
    public PublicDbContext(DbContextOptions<PublicDbContext> options)  : base(options)
    {
    }
    public DbSet<CategoriesCatalog> CategoriesCatalogs { get; set; }
    public DbSet<CategoryOptions> CategoryOptions { get; set; }
    public DbSet<Chapters> Chapters { get; set; }
    public DbSet<OptionQuestions> OptionsQuestions { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<OptionsResponse> OptionsResponses { get; set; }
    public DbSet<SubQuestions> SubQuestions { get; set; }
    public DbSet<SumaryOptions> SumaryOptions { get; set; }
    public DbSet<Surveys> Surveys { get; set; }


   // public DbSet<Country> Countries { get; set; }
    // public DbSet<State> States { get; set; }
    //  public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PublicDbContext).Assembly);
    }
}
