using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Blog.Models
{
    public class Skill : BaseModel
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public int UserId { get; set; }
    }
}