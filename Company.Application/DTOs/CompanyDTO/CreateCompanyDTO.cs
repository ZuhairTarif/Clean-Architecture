
namespace Company.Application.DTOs.CompanyDTO
{
    public class CreateCompanyDTO
    {
        public string CompanyName { get; set; }
        public string CompanyNameBn { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine1Bn { get; set; }
        public string AddressLine2Bn { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

    }
}
