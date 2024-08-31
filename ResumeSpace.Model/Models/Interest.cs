using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeSpace.Model.Models
{
    public class Interest : BaseModel
    {
        public string Name { get; set; }
        public string IconCssClass { get; set; }
        public int ResumeId { get; set; }
    }
}
