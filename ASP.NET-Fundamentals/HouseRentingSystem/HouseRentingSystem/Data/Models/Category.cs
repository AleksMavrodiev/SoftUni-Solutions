using HouseRentingSystem.Common;
using System.ComponentModel.DataAnnotations;


namespace HouseRentingSystem.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(DataConstrainst.Category.NameMaxLength)]
        public string Name { get; set; } = null!;

    }
}
