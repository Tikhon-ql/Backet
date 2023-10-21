using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Models.Identity
{
    public class Role : BaseEntity
    {
        [Required]
        public string RoleName { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
