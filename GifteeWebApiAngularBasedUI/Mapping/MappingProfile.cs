﻿using AutoMapper;
using GifteeWebApiAngularBasedUI.Controllers.Resources;
using GifteeWebApiAngularBasedUI.Core.Models;

namespace GifteeWebApiAngularBasedUI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain class to API resource
            CreateMap<User, UserResource>();
            CreateMap<Giftee, GifteeResource>();

            // Api resource to domain class
            CreateMap<GifteeResource, Giftee>()
                .ForMember(g => g.Id, opt => opt.Ignore())
                .ForMember(g => g.FirstName, opt => opt.MapFrom(gr => gr.FirstName))
                .ForMember(g => g.LastName, opt => opt.MapFrom(gr => gr.LastName))
                .ForMember(g => g.Email, opt => opt.MapFrom(gr => gr.Email))
                .ForMember(g => g.UserId, opt => opt.MapFrom(gr => gr.UserId));
        }
    }
}
