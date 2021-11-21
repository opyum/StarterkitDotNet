using AutoMapper;
using Commun.Enums;
using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.Entity;
using DataAccessLayer.UnifOfWork;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StarterKitAPI.Attributes;
using StarterKitAPI.Extension;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace StarterKitAPI.Services
{
    public class PersonneService : BaseService<SqliteContext>, IPersonneService
    {
        private IGenericRepository<Personne> _personneRepo { get; set; }
        private ILogService _logService { get; set; }

        public PersonneService(IUnitOfWork<SqliteContext> uow, IMapper mapper, ILogService logService) : base(uow, mapper)
        {
            _personneRepo = unitOfWork.GetRepository<Personne>();
            _logService = logService;
        }

        public IEnumerable<PersonneDTO> GetAll()
        {
            var retour = _personneRepo.GetAll().Select(x => _mapper.Map<PersonneDTO>(x)).ToList();
            return retour;
        }

        public PersonneDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MessageObjectDTO<PersonneDTO> CreatePersonne(PersonneDTO user)
        {
            MessageObjectDTO<PersonneDTO> retour = new MessageObjectDTO<PersonneDTO>();
            try
            {
                _logService.CreateLog(SeverityEnum.INFORMATION, user, "Debut d'appel");

                Personne personne = _mapper.Map<Personne>(user);
                retour.Object = _mapper.Map<PersonneDTO>(_personneRepo.Add(personne));
                unitOfWork.Save();

                
                return retour;
            }
            catch (Exception e)
            {
                _logService.CreateLog(SeverityEnum.ERROR, user, e.Message + " " + e.InnerException);
                throw e;
            }

        }

        public void Update(PersonneDTO dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idAppli)
        {
            throw new NotImplementedException();
        }

    }
}