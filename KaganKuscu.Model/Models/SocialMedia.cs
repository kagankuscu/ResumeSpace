using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class SocialMedia : BaseModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int ResumeId { get; set; }
        public string IconCssClass { get; set; }
    }
}