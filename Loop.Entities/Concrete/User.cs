using System.Collections.Generic;

namespace Loop.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public virtual ICollection<Post> Posts { get; set; }
    }
}
