using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public int IsActive { get; set; }

    }
}
