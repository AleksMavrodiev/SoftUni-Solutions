using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Core.Models;

namespace ForumApp.Core.Contracts
{
    public interface IPostService
    {
        Task<ICollection<PostViewModel>> GetAllAsync();
        Task AddPostAsync(PostFormModel postFormModel);

        Task<PostFormModel> GetPostByIdAsync(string postId);
    }
}
