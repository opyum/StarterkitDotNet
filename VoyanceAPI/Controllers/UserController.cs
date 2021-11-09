using Commun.Constantes;
using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarterKitAPI.Services;
using System.Collections.Generic;

namespace StarterKitAPI.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route(ApiRouteConst.LOGIN_CONTROLLER)]
    public class PersonneController : ControllerBase
    {

        private IPersonneService UserService;

        public PersonneController(IPersonneService service)
        {
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
        public IActionResult Create(PersonneDTO User)
        {
            UserService.Create(User);
            return Ok();
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
