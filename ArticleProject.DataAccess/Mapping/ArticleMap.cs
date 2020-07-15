using ArticleProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.DataAccess.Mapping
{
    public class ArticleMap
    {
        public ArticleMap(EntityTypeBuilder<Article> entity)
        {
            entity.HasKey(a => a.ID);

            entity.Property(a => a.Title)
                .HasMaxLength(500)
                .IsRequired();

            entity.Property(a => a.Author)
                .HasMaxLength(255)
                .IsRequired();

            entity.Property(a => a.Abstract)
                .IsRequired();

            entity.Property(a => a.Summary)
                .IsRequired();

            entity.Property(a => a.Content)
                .IsRequired();
        }
    }
}
