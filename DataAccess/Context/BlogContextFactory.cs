using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class BlogContextFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        public BlogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogContext>();
            optionsBuilder.UseMySql("Server=3.137.76.131;Database=BlogDb;Uid=kubra;Pwd=Kk123456.;", new MySqlServerVersion(new Version("8.0.30")));

            return new BlogContext(optionsBuilder.Options);
        }
    }
}
