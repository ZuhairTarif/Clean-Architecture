namespace Company.Application.Features.Company.Requests.Queries
{
    public class GetCompanyListRequest : IRequest<List<CompanyDTO>>
    {
        public int CompanyId { get; set; }

    }
}
