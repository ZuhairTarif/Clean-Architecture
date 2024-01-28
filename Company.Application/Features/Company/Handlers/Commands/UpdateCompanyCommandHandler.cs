using AutoMapper;
using Company.Application.Features.Company.Requests.Commands;
using Company.Application.Contracts.Persistence;
using MediatR;

namespace Company.Application.Features.Company.Handlers.Commands
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, Unit>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public UpdateCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.Get(request.UpdateCompanyDTO.CompanyId);
            _mapper.Map(request.UpdateCompanyDTO, company);
            await _companyRepository.Update(company);
            return Unit.Value;
        }
    }
}
