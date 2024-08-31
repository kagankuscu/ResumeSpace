using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSpace.Model.Models
{
    public class Photo : BaseModel
    {
        public string PhotoPath { get; set; }
        public int BlogId { get; set; }
    }
}