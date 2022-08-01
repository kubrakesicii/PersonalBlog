using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Percentage { get; set; }
        public int IsActive { get; set; }
    }
}
