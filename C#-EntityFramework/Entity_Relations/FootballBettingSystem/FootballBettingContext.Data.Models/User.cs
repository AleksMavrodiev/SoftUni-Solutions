using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Data.Common;

namespace FootballBettingContext.Data.Models
{
    public class User
    {
        public User()
        {
            this.Bets = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

        [MaxLength(ValidationConstraints.UserUsernameMaxLength)]
        public string UserName { get; set; } = null!;

        [MaxLength(ValidationConstraints.UserPasswordMaxLength)]
        public string Password { get; set; } = null!;

        [MaxLength(ValidationConstraints.UserEmailMaxLength)]
        public string Email { get; set; } = null!;

        [MaxLength(ValidationConstraints.UserNameMaxLength)]
        public string Name { get; set; } = null!;

        public decimal Balance { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
