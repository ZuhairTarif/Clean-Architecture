namespace Company.Application.Features.Company.Requests.Commands
{
    public class CreateCompanyCommandRequest : IRequest<BaseCommandResponse>
    {
        public int CompanyId { get; set; }
        public CreateCompanyDTO CreateCompanyDTO { get; set; }
    }
}
