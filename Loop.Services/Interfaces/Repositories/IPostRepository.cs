using Loop.Entities;
using System;
using System.Collections.Generic;

namespace Loop.Services.Repositories_interface
{
    public interface IPostRepository :IRepository<Post>
    {
        void Insert(Post post, IEnumerable<int> SelectedTagsIds);
        void Update(Post post, IEnumerable<int> SelectedTagsIds);
        

    }
}
