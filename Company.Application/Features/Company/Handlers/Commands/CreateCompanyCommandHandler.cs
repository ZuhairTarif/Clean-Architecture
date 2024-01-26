using AutoMapper;
using Company.Application.Features.Company.Requests.Commands;
using Company.Application.Persistence.Contracts;
using MediatR;
using Company.Domain;

namespace Company.Application.Features.Company.Handlers.Commands
{
    public class CreateCompanyListRequestHandler : IRequestHandler<CreateCompanyCommandRequest, int>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public CreateCompanyListRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company = _mapper.Map<CompanyModel>(request.CreateCompanyDTO);
            company = await _companyRepository.Add(company);
            return company.CompanyId;

        }
    }
}
