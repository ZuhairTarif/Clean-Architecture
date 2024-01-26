using Company.Application.DTOs;
using MediatR;


namespace Company.Application.Features.Company.Requests.Queries
{
    public class GetCompanyListRequest : IRequest<List<CompanyDTO>>
    {


    }
}
