using DataAccessLayer;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataAccessLayer.Entity;

namespace StarterKitAPI.Profile
{
    public class PersonneProfile : AutoMapper.Profile
    {
        public PersonneProfile()
        {
            CreateMap<Personne, PersonneDTO>()
                .ReverseMap();
        }
    }
}
