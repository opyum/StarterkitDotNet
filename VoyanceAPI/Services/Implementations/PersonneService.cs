using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.Entity;
using DataAccessLayer.UnifOfWork;
using DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    public class PersonneService : BaseService, IPersonneService
    {
        private IGenericRepository<Personne> _personneRepo { get; set; }
        private IGenericRepository<Log> _logRepo { get; set; }

        public PersonneService(IUnitOfWork<SqliteContext> uow, IUnitOfWork<LogContext> logUnitOfWork, IMapper mapper) : base(uow, logUnitOfWork, mapper)
        {
            _personneRepo = unitOfWorkSqlite.GetRepository<Personne>();
            _logRepo = unitOfWorkLog.GetRepository<Log>();
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



        public void Create(PersonneDTO user)
        {
            
            Log log = new Log() { Data = JsonSerializer.Serialize(user), ErrorMessage = "Pas d'erreur", Id = Thread.CurrentThread.ManagedThreadId, ThreadId = "psdjfpodfjs" };
            _logRepo.Add(log);
            unitOfWorkLog.Save();

            Personne personne = _mapper.Map<Personne>(user);
            _personneRepo.Add(personne);
            unitOfWorkSqlite.Save();
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