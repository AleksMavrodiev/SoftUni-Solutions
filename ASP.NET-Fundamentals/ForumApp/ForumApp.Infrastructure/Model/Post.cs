using System.ComponentModel.DataAnnotations;
using ForumApp.Common;

namespace ForumApp.Infrastructure.Model
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Range(2, DataConstraints.TitleMaxLength)]
        public string Title { get; set; } = null!;
        [Required]
        [Range(2, DataConstraints.ContentMaxLength)]
        public string Content { get; set; } = null!;
    }
}