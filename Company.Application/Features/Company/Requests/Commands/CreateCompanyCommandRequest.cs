using Company.Application.DTOs.CompanyDTO;
using MediatR;

namespace Company.Application.Features.Company.Requests.Commands
{
    public class CreateCompanyCommandRequest : IRequest<int>
    {
        public int CompanyId { get; set; }
        public CreateCompanyDTO CreateCompanyDTO { get; set; }
    }
}
