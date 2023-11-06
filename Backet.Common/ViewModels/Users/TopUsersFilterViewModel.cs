using Backet.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Common.ViewModels.Users
{
    public class TopUsersFilterViewModel : BaseFilterViewModel
    {
        public bool? SortByAscend { get; set; }
        public StatsType? SortBy { get; set; }
    }
}
