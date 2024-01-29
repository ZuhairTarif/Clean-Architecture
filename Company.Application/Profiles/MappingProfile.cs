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
