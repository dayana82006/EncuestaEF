
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configuration;
  public class CategoriesCatalogConfiguration : IEntityTypeConfiguration<CategoriesCatalog>
    {
        public void Configure(EntityTypeBuilder<CategoriesCatalog> builder)
        {
            builder.ToTable("CategoriesCatalog");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasMany(c => c.CategoryOptions)
                   .WithOne(co => co.CategoriesCatalog)
                   .HasForeignKey(co => co.CategoriesCatalogId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.OptionQuestions)
                   .WithOne(oq => oq.CategoriesCatalog)
                   .HasForeignKey(oq => oq.CategoriesCatalogId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }