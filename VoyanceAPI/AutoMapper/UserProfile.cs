using DataAccessLayer;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataAccessLayer.Entity;

namespace VoyanceApi.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Id, source => source.MapFrom(x => x.Id))
                .ReverseMap();
        }
    }
}
