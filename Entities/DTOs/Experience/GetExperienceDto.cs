using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Experience
{
    public class GetExperienceDto
    {
        public int Id { get; set; }
        public string TimeInterval { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
