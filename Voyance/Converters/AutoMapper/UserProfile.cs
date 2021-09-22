using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Voyance.Models;

namespace Voyance.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<UserVM, UserDTO>().ReverseMap();
        }
    }
}
