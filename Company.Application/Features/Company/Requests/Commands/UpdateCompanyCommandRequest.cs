using Company.Application.DTOs.CompanyDTO;
using MediatR;


namespace Company.Application.Features.Company.Requests.Commands
{
    public class UpdateCompanyCommandRequest : IRequest<Unit>
    { 
        public UpdateCompanyDTO UpdateCompanyDTO { get; set; }
    }
}
