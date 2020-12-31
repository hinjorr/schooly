using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.DTO
{
    public class InstituteModel
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Country { get; set; }
        public string Phone { get; set; }
        public string Moto { get; set; }
        public string Website { get; set; }
        public int? AdmissionFee { get; set; }
        public int? RegistrationFee { get; set; }
        public int? TransportFee { get; set; }
        public int? BooksFee { get; set; }
        public int? FineFee { get; set; }
        public string RulesRegulations { get; set; }
    }
}
