using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Skill : BaseModel
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

    }
}