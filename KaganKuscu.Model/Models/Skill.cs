using KaganKuscu.Model.ManyToMany;

namespace KaganKuscu.Model.Models
{
    public class Skill : BaseModel
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public Guid AppUserId { get; set; }
        public virtual ICollection<Person> People { get; set; } = new List<Person>(); 
        public ICollection<PersonSkill> PersonSkills { get; set; } = [];

    }
}