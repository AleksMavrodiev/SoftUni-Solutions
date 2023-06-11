using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService; 
        }
        public async Task<IActionResult> All()
        {
            ICollection<PostViewModel> posts = await this.postService.GetAllAsync();

            return View((List<PostViewModel>)posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel postFormModel)
        {
            if (!ModelState.IsValid)
            {
                return View(postFormModel);
            }

            try
            {
                await this.postService.AddPostAsync(postFormModel);
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while adding your post!");
                return View(postFormModel);
            }

            return RedirectToAction("All");
        }

        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                PostFormModel postModel =
                    await this.postService.GetPostByIdAsync(id);

                return View(postModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Post");
            }
        }
    }
}
