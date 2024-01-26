using AutoMapper;
using Company.Application.DTOs;
using Company.Application.Features.Company.Requests.Queries;
using Company.Application.Persistence.Contracts;
using MediatR;

namespace Company.Application.Features.Company.Handlers.Queries
{
    public class GetCompanyListRequestHandler : IRequestHandler<GetCompanyListRequest, List<CompanyDTO>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public GetCompanyListRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }

        public async Task<List<CompanyDTO>> Handle(GetCompanyListRequest request, CancellationToken cancellationToken)
        {
            var companyType = await _companyRepository.GetAll();
            return _mapper.Map<List<CompanyDTO>>(companyType);
        }
    }
}
