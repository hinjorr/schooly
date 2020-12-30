using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblCountries
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
