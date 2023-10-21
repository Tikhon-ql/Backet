using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Models.Identity
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual List<Role> Roles { get; set; }
        public virtual List<PlayStats> Stats { get; set; }
    }
}
