using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class Tblschoolconfig
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public string Phone { get; set; }
        public string Moto { get; set; }
        public string Website { get; set; }
        public int? AdmissionFee { get; set; }
        public int? RegistrationFee { get; set; }
        public int? TransportFee { get; set; }
        public int? BooksFee { get; set; }
        public int? FineFee { get; set; }
        public string RulesRegulations { get; set; }

        public virtual TblCountries Country { get; set; }
    }
}
