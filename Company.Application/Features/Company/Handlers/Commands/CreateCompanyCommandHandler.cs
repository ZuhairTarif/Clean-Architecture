namespace Company.Application.Features.Company.Handlers.Commands
{
    public class CreateCompanyListRequestHandler : IRequestHandler<CreateCompanyCommandRequest, BaseCommandResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public CreateCompanyListRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            this._companyRepository = companyRepository;
            this._mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateCompanyDTOValidator();
            var validationResult = await validator.ValidateAsync(request.CreateCompanyDTO);

            if (validationResult.IsValid ==  false)
            {
                response.Success = false;
                response.Message = "Failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
                //throw new ValidationException(validationResult);
            }

            var company = _mapper.Map<CompanyModel>(request.CreateCompanyDTO);
            company = await _companyRepository.Add(company);

            response.Success = true;
            response.Message = "Successful";
            response.ResponseId = company.CompanyId;
            return response;

            //return company.CompanyId;

        }
    }
}
