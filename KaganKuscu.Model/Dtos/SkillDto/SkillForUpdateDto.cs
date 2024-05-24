using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Dtos.Skills
{
    public record SkillForUpdateDto
    {
       public Guid Guid { get; init; }
       public Guid AppUserId { get; set; }
       public string FullName { get; init; } = string.Empty;
       public string Name { get; init; } = string.Empty; 
       public int Percent { get; init; }
       public bool IsActive { get; set; }
       public ICollection<int> Resumes { get; set; } = [];
    }
}