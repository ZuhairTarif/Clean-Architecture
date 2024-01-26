using Company.Application.DTOs.Common;
using System;
using System.Collections.Generic;

namespace Company.Application.DTOs.CompanyDTO
{
    public class UpdateCompanyDTO : BaseDTO
    {
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
