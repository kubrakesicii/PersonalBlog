using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Text).IsRequired();
            builder.HasOne(x => x.Blog)
                   .WithMany()
                   .HasForeignKey(x => x.BlogId);
        }
    }
}
