using AutoMapper;
using GifteeWebApiAngularBasedUI.Controllers.Resources;
using GifteeWebApiAngularBasedUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();
            CreateMap<Giftee, GifteeResource>();
        }
    }
}
