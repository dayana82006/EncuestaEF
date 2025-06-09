
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configuration;

public class ChaptersConfiguration : IEntityTypeConfiguration<Chapters>
{
    public void Configure(EntityTypeBuilder<Chapters> builder)
    {
        builder.ToTable("Chapters");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.SurveyId)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(c => c.CreatedAt)
               .IsRequired();

        builder.Property(c => c.UpdatedAt)
               .IsRequired();

        builder.Property(c => c.ComponentHtml)
                .IsRequired()
                .HasMaxLength(5000);
        builder.Property(c => c.ComponentReact)
                .IsRequired()
                .HasMaxLength(5000);
        builder.Property(c => c.ChapterNumber)
                .IsRequired()
                .HasMaxLength(50);
        builder.Property(c => c.ChapterTitle)
                .IsRequired()
                .HasMaxLength(200);
        builder.HasOne(c => c.Surveys)
               .WithMany(s => s.Chapters)
               .HasForeignKey(c => c.SurveyId)
               .OnDelete(DeleteBehavior.Cascade);
        
  }
}
