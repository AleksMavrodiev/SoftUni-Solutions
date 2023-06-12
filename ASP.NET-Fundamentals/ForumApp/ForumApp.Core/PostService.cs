using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Core
{
    public class PostService : IPostService
    {
        private ForumDbContext dbContext;

        public PostService(ForumDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ICollection<PostViewModel>> GetAllAsync()
        {
            ICollection<PostViewModel> posts = await dbContext.Posts.Select(p => new PostViewModel()
            {
                Id = p.Id.ToString(),
                Content = p.Content,
                Title = p.Title
            }).ToListAsync();

            return posts;
        }

        public async Task AddPostAsync(PostFormModel postFormModel)
        {
            Post newPost = new Post()
            {
                Title = postFormModel.Title,
                Content = postFormModel.Content
            };

            await this.dbContext.Posts.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostFormModel> GetPostByIdAsync(string postId)
        {
            Post postToEdit = await this.dbContext.Posts.FirstOrDefaultAsync(p => p.Id.ToString() == postId);

            return new PostFormModel()
            {
                Title = postToEdit.Title,
                Content = postToEdit.Content
            };

        }

        public async Task EditByIdAsync(string postId, PostFormModel model)
        {
            Post post = await this.dbContext.Posts.FirstOrDefaultAsync(p => p.Id.ToString() == postId);
            post.Content = model.Content;
            post.Title = model.Title;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(string postId)
        {
            Post post = await this.dbContext.Posts.FirstOrDefaultAsync(p => p.Id.ToString() == postId);
            this.dbContext.Posts.Remove(post);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
