using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Person : BaseModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ResumePath { get; set; }
    }
}