using Entities.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Blog
{
    public class GetPopularBlogDto
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public string CoverImage { get; set; }
        public GetCategoryDto Category { get; set; }
    }
}
