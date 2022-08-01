using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string CoverImage { get; set; }
        public string Content { get; set; }  // HTML içeriği olarak eklenecek
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int IsActive { get; set; }

    }
}
