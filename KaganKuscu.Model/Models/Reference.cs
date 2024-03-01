using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Reference : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string ImagePath { get; set; }
        public int PersonId { get; set; }
    }
}