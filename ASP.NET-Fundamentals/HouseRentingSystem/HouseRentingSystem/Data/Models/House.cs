using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Common;

namespace HouseRentingSystem.Data.Models
{
    public class House
    {
        public House()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(DataConstrainst.House.TitleMaxLength, MinimumLength = DataConstrainst.House.TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DataConstrainst.House.AddressMaxLength, MinimumLength = DataConstrainst.House.AddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(DataConstrainst.House.DescriptionMaxLength, MinimumLength = DataConstrainst.House.DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range((double)DataConstrainst.House.MinPricePerMonth, (double)DataConstrainst.House.MaxPricePerMonth)]
        public decimal PricePerMonth { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        [Required] 
        public Guid AgentId { get; set; } 

        public Agent Agent { get; set; } = null!;
        public Guid RenterId { get; set; } 

    }
}
