using AutoMapper;
using DataAccessLayer;
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

namespace StarterKitAPI.Services
{
    public class PersonneService : BaseService, IPersonneService
    {
        private IGenericRepository<Personne> _personneRepo { get; set; }

        public PersonneService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            _personneRepo = unitOfWork.GetRepository<Personne>();
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
            Personne personne = _mapper.Map<Personne>(user);
            _personneRepo.Add(personne);
            unitOfWork.Save();
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