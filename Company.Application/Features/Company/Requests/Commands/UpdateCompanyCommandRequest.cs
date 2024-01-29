namespace Company.Application.Features.Company.Requests.Commands
{
    public class UpdateCompanyCommandRequest : IRequest<Unit>
    { 
        public UpdateCompanyDTO UpdateCompanyDTO { get; set; }
    }
}
