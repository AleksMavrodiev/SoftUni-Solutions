﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        [Key] 
        public int ResourceId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Unicode(false)]
        public string Url { get; set; }
        [Required] public ResourceType ResourceType { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
