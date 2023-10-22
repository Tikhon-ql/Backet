using Backet.DataProvider.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Logic.Models.Identity
{
    public class RoleDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
    }
}
