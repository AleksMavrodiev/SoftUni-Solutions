using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Common;

namespace ForumApp.Core.Models
{
    public class PostFormModel
    {
        [Required]
        [StringLength(DataConstraints.TitleMaxLength, MinimumLength = DataConstraints.TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DataConstraints.ContentMaxLength, MinimumLength = DataConstraints.ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
