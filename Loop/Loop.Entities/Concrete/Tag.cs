using System.Collections.Generic;

namespace Loop.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        
        public virtual ICollection<Post> Posts { get; set; }
    }
}
