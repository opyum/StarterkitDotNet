using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Voyance.Business;
using Voyance.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Web;

namespace Voyance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IUserBusiness userBusiness;
        public HomeController(ILogger<HomeController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            this.userBusiness = userBusiness;
        }

        public IActionResult Index()
        {
            //var test = authenticationBusiness.Authenticate(User.Identity.Name);
            //var cookieOptions = new CookieOptions();
            //cookieOptions.Expires = DateTimeOffset.UtcNow.AddHours(4);//you can set this to a suitable timeframe for your situation 
            //cookieOptions.Domain = Request.Host.Value;
            //cookieOptions.Path = "/";
            //cookieOptions.IsEssential = true;
            //cookieOptions.HttpOnly = false;
            //Response.Cookies.Append("jwt", test.JwtToken, cookieOptions);
            userBusiness.GetAllUsersWithRole(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

     
    }
}
