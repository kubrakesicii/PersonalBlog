using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(x => x.Topic).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Date).IsRequired();
        }
    }
}
