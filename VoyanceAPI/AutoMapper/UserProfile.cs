using DataAccessLayer;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataAccessLayer.Entity;

namespace StarterKitAPI.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Personne, PersonneDTO>()
                .ForMember(dest => dest.Id, source => source.MapFrom(x => x.Id))
                .ReverseMap();
        }
    }
}
