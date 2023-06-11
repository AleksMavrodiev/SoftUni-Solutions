using ForumApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Seeder
{
    class PostSeeder
    {
        internal Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();
            Post currentPost;

            currentPost = new Post()
            {
                Title = "My first post",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed venenatis libero vel nibh ultricies mattis. Sed sagittis sem in leo."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title = "My second post",
                Content =
                    "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title = "My third post",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel pretium velit, eget imperdiet massa. In diam dolor, hendrerit. "
            };
            posts.Add(currentPost);

            return posts.ToArray();
        }
    }
}
