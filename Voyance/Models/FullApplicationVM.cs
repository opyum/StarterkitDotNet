using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class FullApplicationVM
    {
        public ApplicationVM AppliVM { get; set; }
        public List<SpecificsRightsVM> RightsVM { get; set; }
    }
}
