using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Voyance.Helper
{
    public static class ClaimHelper
    {
        public static bool CanAccess(this ClaimsPrincipal principal, string rightToCheck)
        {
  
            bool canAccess = false;
            var claims = principal.Claims;
            if (claims != null && claims.Count() > 0)
            {
                string claim = claims?.FirstOrDefault(x => x.Type.Equals(rightToCheck, StringComparison.OrdinalIgnoreCase))?.Value;
                if (!string.IsNullOrEmpty(claim))
                    Boolean.TryParse(claim, out canAccess);
            }
            return canAccess;
        }
    }
}
