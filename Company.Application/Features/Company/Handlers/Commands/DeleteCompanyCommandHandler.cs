using AutoMapper;
using Company.Application.Features.Company.Requests.Commands;
using Company.Application.Contracts.Persistence;
using MediatR;

namespace Company.Application.Features.Company.Handlers.Commands
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommandRequest, Unit>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.Get(request.CompanyId);
            await _companyRepository.Delete(company);
            return Unit.Value;
        }
    }
}
