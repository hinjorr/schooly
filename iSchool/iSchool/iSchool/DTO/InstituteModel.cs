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
        public string Moto { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Admissionfee { get; set; }
        public string RulesRegulations { get; set; }
        public int Country { get; set; }
    }
}
