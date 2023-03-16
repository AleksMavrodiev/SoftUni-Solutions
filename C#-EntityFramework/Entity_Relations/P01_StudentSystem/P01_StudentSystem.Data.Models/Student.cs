using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Common;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.Homeworks = new HashSet<Homework>();
            this.StudentsCourses = new HashSet<StudentCourse>();
        }
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxStudentNameLength)]
        public string Name { get; set; } = null!;

        [StringLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }

        [Required] 
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
        public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}