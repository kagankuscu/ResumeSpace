using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Blog.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ResumePath { get; set; }
    }
}