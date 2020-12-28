using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblSchoolconfig
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Moto { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Admissionfee { get; set; }
        public string RulesRegulations { get; set; }
    }
}
