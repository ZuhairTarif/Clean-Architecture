using Company.Application.DTOs.CompanyDTO;
using Company.Application.Features.Company.Requests.Commands;
using Company.Application.Features.Company.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyDTO>>> Get()
        {
            var company = await _mediator.Send(new GetCompanyListRequest());
            return Ok(company);
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCompanyDTO company)
        {
            var command = new CreateCompanyCommandRequest
            {
                CreateCompanyDTO = company
            };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCompanyDTO company)
        {
            var command = new UpdateCompanyCommandRequest
            {
                UpdateCompanyDTO = company
            };

            await _mediator.Send(command);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCompanyCommandRequest { CompanyId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}


