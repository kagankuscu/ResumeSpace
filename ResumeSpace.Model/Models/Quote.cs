using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSpace.Model.Models
{
    public class Quote : BaseModel
    {
        public string Owner { get; set; }
        public string Content { get; set; }
    }
}