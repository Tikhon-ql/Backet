using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backet.DataProvider.Models.Identity;

namespace Backet.DataProvider.Models
{
    public class PlayStats : BaseEntity
    {
        [Required]
        public int Points { get; set; }
        [Required]
        public int Assists { get; set; }
        [Required]
        public int Rebounds { get; set; }
        [Required]
        public int Steals { get; set; }

        [Required]
        public virtual User User { get; set; }
    }
}
