﻿using Backet.DataProvider.Models.Identity;
using Backet.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Logic.Models.Identity
{
    public class UserDto
    {
        public Guid Id { get;set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<RoleDto> Roles { get; set; }
        public List<PlayStatsDto> Stats { get; set; }
    }
}
