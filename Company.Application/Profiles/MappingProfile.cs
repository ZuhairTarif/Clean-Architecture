using AutoMapper;
using Company.Application.DTOs.CompanyDTO;
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
