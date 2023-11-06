using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Common.ViewModels
{
    public class BaseFilterViewModel
    {
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
