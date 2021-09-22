using AutoMapper;
using Commun.Constantes;
using Commun.Enums;
using DTOs;
using Newtonsoft.Json;
using Voyance.Helper;
using Voyance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Business
{
    public class UserBusiness : BaseBusiness, IUserBusiness
    {
        private readonly IApiService _apiService;
        public UserBusiness(IMapper mapper, IApiService apiService) : base(mapper)
        {
            _apiService = apiService;
        }
        public void GetAllUsersWithRole(int idRole)
        {
            string response = _apiService.CallApi(HttpVerbsEnums.GET, ApiRouteConst.LOGIN_CONTROLLER, ApiRouteConst.GENERIC_GET_ALL, new UrlParameter(nameof(idRole), idRole.ToString()).ToArray()).Result;
        }
    }
}
