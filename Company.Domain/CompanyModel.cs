using Company.Domain.Common;
using System.ComponentModel.DataAnnotations;


namespace Company.Domain
{
    public class CompanyModel : BaseEntityDomain
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameBn { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine1Bn { get; set; }
        public string AddressLine2Bn { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
