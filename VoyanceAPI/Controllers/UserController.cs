using Commun.Constantes;
using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VoyanceApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace VoyanceApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route(ApiRouteConst.LOGIN_CONTROLLER)]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        private ILoginService UserService;

        public LoginController(ILogger<LoginController> logger, ILoginService service)
        {
            _logger = logger;
            UserService = service;
        }

        [HttpGet]
        [Route(ApiRouteConst.GENERIC_GET_ALL)]
        public IEnumerable<UserDTO> GetAll()
        {

            return UserService.GetAll();
        }

        [HttpGet]
        [Route(ApiRouteConst.USER_CONTROLLER_GET_ALL_WITH_ROLE)]
        public void GetAllWithRole(int idRole)
        {
            UserService.GetAllWithRole(idRole);
        }

        [HttpGet]
        [Route(ApiRouteConst.GENERIC_GET_BY_ID)]
        public UserDTO GetById(int id)
        {
            return UserService.GetById(id);
        }

        [HttpPost]
        [Route(ApiRouteConst.GENERIC_CREATE)]
        public void Create(UserDTO User)
        {
            UserService.Create(User);
        }     
        
        

        [HttpPut]
        [Route(ApiRouteConst.GENERIC_UPDATE)]
        public void Update(UserDTO dto)
        {
             UserService.Update(dto);
        }
        [HttpDelete]
        [Route(ApiRouteConst.GENERIC_DELETE)]
        public void Delete(int idAppli)
        {
             UserService.Delete(idAppli);
        }
    }
}
