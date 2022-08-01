using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Experience
    {
        public int Id { get; set; }
        public string TimeInterval { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public int Type { get; set; }    // 1 : School Exp   2 : Work Exp
        public int IsActive { get; set; }
    }
}
