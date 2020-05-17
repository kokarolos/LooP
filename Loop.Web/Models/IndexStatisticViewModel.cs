using Loop.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Loop.Web.Models
{
    public class IndexStatisticViewModel
    {
        public int PostsCount { get; set; }
        public int UsersCount { get; set; }
        public int ProductsCount { get; set; }
        public int OrdersCount { get; set; }
        public IEnumerable<Post> RecentPosts { get; set; }

    }
}