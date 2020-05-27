using Loop.Entities;
using Loop.Entities.Concrete;
using System.Collections.Generic;

namespace Loop.Web.Models
{
    public class IndexStatisticViewModel
    {
        public int PostsCount { get; set; }
        public int UsersCount { get; set; }
        public int ProductsCount { get; set; }
        public int OrdersCount { get; set; }
        public IEnumerable<Post> RecentPosts { get; set; }
        public IEnumerable<Product> RecentProducts { get; set; }
        public IEnumerable<Reply> RecentReplies { get; set; }
        public Dictionary<string,int> RecomendedProducts { get; set; }


    }
}