using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Models
{
    public class ModelDropDown
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public int ReligionId { get; set; }
        public string Religion { get; set; }

        public int CId { get; set; }
        public string CName { get; set; }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}
