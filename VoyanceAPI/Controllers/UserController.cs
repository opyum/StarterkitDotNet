using Commun.Constantes;
using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarterKitAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StarterKitAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route(ApiRouteConst.LOGIN_CONTROLLER)]
    public class PersonneController : ControllerBase
    {
        private readonly ILogger<PersonneController> _logger;

        private IPersonneService UserService;

        public PersonneController(ILogger<PersonneController> logger, IPersonneService service)
        {
            _logger = logger;
            UserService = service;
        }

        [HttpGet]
        [Route(ApiRouteConst.GENERIC_GET_ALL)]
        public IEnumerable<PersonneDTO> GetAll()
        {

            return UserService.GetAll();
        }

        [HttpGet]
        [Route(ApiRouteConst.GENERIC_GET_BY_ID)]
        public PersonneDTO GetById(int id)
        {
            return UserService.GetById(id);
        }

        [HttpPost]
        [Route(ApiRouteConst.GENERIC_CREATE)]
        public void Create(PersonneDTO User)
        {
            UserService.Create(User);
        }     
        
        

        [HttpPut]
        [Route(ApiRouteConst.GENERIC_UPDATE)]
        public void Update(PersonneDTO dto)
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
