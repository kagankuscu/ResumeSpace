using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaganKuscu.Model.Models
{
    public class Blog : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PersonId { get; set; }

        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>()
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}