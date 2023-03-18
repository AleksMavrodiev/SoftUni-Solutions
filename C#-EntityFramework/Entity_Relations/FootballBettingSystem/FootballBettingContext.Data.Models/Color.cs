using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Data.Common;

namespace FootballBettingContext.Data.Models
{
    public class Color
    {
        public Color()
        {
            this.PrimaryKitTeams = new HashSet<Team>();
            this.SecondaryKitTeams = new HashSet<Team>();
        }
        [Key] 
        public int ColorId { get; set; }
        [MaxLength(ValidationConstraints.ColorNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Team> PrimaryKitTeams { get; set; }
        public virtual ICollection<Team> SecondaryKitTeams { get; set; }
    }
}
