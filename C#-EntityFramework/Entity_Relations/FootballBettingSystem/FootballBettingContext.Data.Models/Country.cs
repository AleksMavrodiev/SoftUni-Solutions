using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Data.Common;

namespace FootballBettingContext.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }
        [Key]
        public int CountryId { get; set; }

        [MaxLength(ValidationConstraints.CountryNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Town> Towns { get; set; }
    }
}
