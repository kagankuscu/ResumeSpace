using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSpace.Model.Models
{
    public class Blog : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int ResumeId { get; set; }

        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public virtual Resume? Resume { get; set; }
    }
}