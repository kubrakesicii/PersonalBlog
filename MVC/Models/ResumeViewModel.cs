using Entity.Concrete;
using System.Collections.Generic;

namespace MVC.Models
{
    public class ResumeViewModel
    {
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
