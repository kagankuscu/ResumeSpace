using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Comment : BaseModel
    {
        public string Content { get; set; }
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
    }
}