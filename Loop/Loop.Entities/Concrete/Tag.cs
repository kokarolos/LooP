using System.Collections.Generic;

namespace Loop.Entities
{
    //TODO : Search if Enum must be virtual property for Tag entity
    public class Tag
    {
        public int TagId { get; set; }
        public Subject Subject { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
