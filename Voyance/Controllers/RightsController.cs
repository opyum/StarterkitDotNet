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
using Commun.Enums;

namespace Voyance.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        private IUserBusiness UserBusiness;
        public UserController(ILogger<UserController> logger, IUserBusiness UserBusiness)
        {
            _logger = logger;
            this.UserBusiness = UserBusiness;
        }

        public IActionResult PartialSetSpecificsUser(int idRole = 0)
        {
            ViewBag.IdRole = idRole;
            return PartialView("/Views/User/_SetSpecificsUser.cshtml");
        }

        [HttpGet]
        public IActionResult GetListUser(int idRole = 0)
        {
            UserBusiness.GetAllUsersWithRole(idRole);
            return View();
        }

    }
}
