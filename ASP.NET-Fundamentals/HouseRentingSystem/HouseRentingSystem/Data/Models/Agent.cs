using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Common;
using Microsoft.AspNetCore.Identity;

namespace HouseRentingSystem.Data.Models
{
    public class Agent
    {
        public Agent()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(DataConstrainst.Agent.PhoneNumberMaxLength, MinimumLength = DataConstrainst.Agent.PhoneNumberMinLength)]
        public string PhoneNumber { get; set; } = null!;
        
        [Required] 
        public string UserId { get; set; } = null!;

        public IdentityUser User { get; set; }
    }
}
