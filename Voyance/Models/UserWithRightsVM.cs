using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class UserWithRightsVM 
    {
        public UserVM User { get; set; }
        public bool HasRight { get; set; }

    }
}
