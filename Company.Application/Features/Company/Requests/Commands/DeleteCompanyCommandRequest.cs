namespace Company.Application.Features.Company.Requests.Commands
{
    public class DeleteCompanyCommandRequest : IRequest
    {
        public int CompanyId { get; set; }
    }
}
