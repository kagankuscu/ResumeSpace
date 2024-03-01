using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Author : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}