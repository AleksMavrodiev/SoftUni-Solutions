using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P01_StudentSystem.Data.Common;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentsCourses = new HashSet<StudentCourse>();
            this.Homeworks = new HashSet<Homework>();
            this.Resources = new HashSet<Resource>();
        }
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxCourseNameLength)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Required] 
        public DateTime StartDate { get; set; }

        [Required] 
        public DateTime EndDate { get; set; }
        
        [Required] 
        public decimal Price { get; set; }

        public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
