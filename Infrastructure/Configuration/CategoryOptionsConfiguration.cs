using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

   
    public class CategoryOptionsConfiguration : IEntityTypeConfiguration<CategoryOptions>
    {
        public void Configure(EntityTypeBuilder<CategoryOptions> builder)
        {
            builder.ToTable("CategoryOptions");

            builder.HasKey(co => co.Id);

            builder.Property(co => co.OptionResponseId)
                   .IsRequired();

            builder.HasOne(co => co.CategoriesCatalog)
                   .WithMany(c => c.CategoryOptions)
                   .HasForeignKey(co => co.CategoriesCatalogId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }


