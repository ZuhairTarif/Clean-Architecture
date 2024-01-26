using AutoMapper;
using Company.Application.DTOs;
using Company.Domain;
using System;


namespace Company.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CompanyModel, CompanyDTO>().ReverseMap();


        }
    }
}
