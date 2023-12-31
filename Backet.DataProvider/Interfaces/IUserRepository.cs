﻿using Backet.DataProvider.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User? ReadByEmail(string email);
    }
}
