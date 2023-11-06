using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Common.ViewModels.PlayStats
{
    public class PlayStatsFilterViewModel : BaseFilterViewModel
    {
        public DateTime? Begining { get; set; }
        public DateTime? Ending { get; set;}
    }
}
