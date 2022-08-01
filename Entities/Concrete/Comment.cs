using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        public int Id { get; set; }

        // Yorumun ait oldugu blog
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int IsActive { get; set; }

    }
}
