using System.Collections.Generic;

namespace Loop.Entities
{
    //TODO : Search about Inheritance for Concrete Classes in Entity Framework

    public class Post
    {
        public int PostId { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
