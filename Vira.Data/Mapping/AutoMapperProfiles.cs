using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vira.Core.Domain;
using Vira.Core.Dto;

namespace Vira.Data.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<UserForRegisterDto, User>();
            CreateMap<User,UserForListDto>();
        }

    }
}
