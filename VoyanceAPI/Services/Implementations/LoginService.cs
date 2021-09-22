using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Entity;
using DataAccessLayer.UnifOfWork;
using DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VoyanceApi.Extension;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace VoyanceApi.Services
{
    public class LoginService : BaseService, ILoginService
    {
        private IGenericRepository<User> _userRepo { get; set; }

        public LoginService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _userRepo = unitOfWork.GetRepository<User>();
        }

             public IEnumerable<UserDTO> GetAll()
        {
            var retour = _userRepo.GetAll().Select(x => _mapper.Map<UserDTO>(x)).ToList();
            return retour;
        }

        public UserDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserDTO Authenticate(string userName, string ipAddress)
        {
            throw new NotImplementedException();
        }

        public string RefreshToken(string token, string ipAddress)
        {
            throw new NotImplementedException();
        }

        public bool RevokeToken(string token, string ipAddress)
        {
            throw new NotImplementedException();
        }

        public void Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDTO dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idAppli)
        {
            throw new NotImplementedException();
        }

        public void GetAllWithRole(int idRole)
        {
            //var allUsers = _userRepo.GetAll().Include(x => x.UserRole);
            //var allUsersDTO = _mapper.Map<List<UserDTO>>(allUsers);
            ////var retour = _mapper.Map<List<UserDTO>>(_userRepo.GetAll().Include(x => x.UserRole).Where(x => x.UserRole.Any(y => y.IdRole.Equals(idRole))));
            //List<UserWithRightsDTO> retour = new List<UserWithRightsDTO>();
            //foreach (var user in allUsersDTO)
            //{
            //    UserWithRightsDTO dto = new UserWithRightsDTO();
            //    dto.User = user;
            //    dto.HasRight = allUsers.Any(x => x.UserRole.Any(y => y.IdRole == idRole));
            //    retour.Add(dto);
            //}
            //return retour;
        }
    }
}