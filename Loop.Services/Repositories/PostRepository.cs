using Loop.Database;
using Loop.Entities;
using Loop.Services.Repositories_interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Loop.Services.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {

        public ApplicationDbContext Database
        {
            get { return Context as ApplicationDbContext; }
        }

        public PostRepository(ApplicationDbContext context)
            : base(context)
        {
            

        }

        //Including User Image Table so we can display user who posted
        //TODO : Include ApplicationUser Images but from Replies table
        // .Replies.ApplicationUser.Images smth like this
        public override IEnumerable<Post> GetAll()
        {
           return Database.Posts.Include(posts => posts.ApplicationUser.Images)
                                .Include(post=>post.Replies)
                                .AsEnumerable();
        }

        public void Insert(Post post, IEnumerable<int> SelectedTagsIds)
        {
            Database.Posts.Attach(post);
            Database.Entry(post).Collection("Tags").Load();
            Database.Entry(post).State = EntityState.Added;

            if (!(SelectedTagsIds is null))
            {
                foreach (var id in SelectedTagsIds)
                {
                    Tag tag = Database.Tags.Find(id);
                    if (tag != null)
                    {
                        post.Tags.Add(tag);
                    }
                }
                Database.SaveChanges();
            }
        }


        public void Update(Post post, IEnumerable<int> SelectedTagsIds)
        {
            Database.Posts.Attach(post);
            Database.Entry(post).Collection("Tags").Load();
            post.Tags.Clear();
            Database.SaveChanges();

            if (!(SelectedTagsIds is null))
            {
                foreach (var id in SelectedTagsIds)
                {
                    Tag tag = Database.Tags.Find(id);
                    if (tag != null)
                    {
                        post.Tags.Add(tag);
                    }
                }
                Database.SaveChanges();
            }
            Database.Entry(post).State = EntityState.Modified;
            Database.SaveChanges();
        }

        public override void Remove(Post post)
        {

            var q = Database.Posts.Include(x => x.Replies)
                                  .FirstOrDefault(x => x.PostId == post.PostId);

            Database.Posts.Remove(post);
        }

    }
}
