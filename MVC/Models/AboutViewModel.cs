using Entities.Concrete;
using Entities.DTOs.Experience;
using Entities.DTOs.User;

namespace MVC.Models
{
    public class AboutViewModel
    {
        public GetUserDto User { get; set; }
        public List<GetExperienceDto> WorkExperience { get; set; }
        public List<GetExperienceDto> SchoolExperience { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
