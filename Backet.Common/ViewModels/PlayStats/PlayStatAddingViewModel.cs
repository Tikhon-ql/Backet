using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Common.ViewModels.PlayStats
{
    public class PlayStatAddingViewModel
    {
        [Required]
        public int Points { get; set; }
        [Required]
        public int Assists { get; set; }
        [Required]
        public int Rebounds { get; set; }
        [Required]
        public int Steals { get; set; }
    }
}
