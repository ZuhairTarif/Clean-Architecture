using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Features.Company.Requests.Commands
{
    public class DeleteCompanyCommandRequest : IRequest
    {
        public int CompanyId { get; set; }
    }
}
