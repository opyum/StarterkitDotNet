using Microsoft.AspNetCore.Http;
using Voyance.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Voyance.Helper
{
    public static class Utils
    {
        public static UrlParameter[] ToArray(this UrlParameter param)
        {
            return new UrlParameter[1] { param };
        }
    }
}
