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
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Link).HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.PublishDate).IsRequired().HasMaxLength(150);
        }
    }
}
