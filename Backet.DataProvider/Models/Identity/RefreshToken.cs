using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Models.Identity
{
    public class RefreshToken : BaseEntity
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
