using Company.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Features.Company.Requests.Commands
{
    public class CreateCompanyCommand : IRequest<int>
    {
        public int CompanyId { get; set; }
        public CompanyDTO CompanyDTO { get; set; }
    }
}
