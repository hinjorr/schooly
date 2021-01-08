using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblCountries
    {
        public TblCountries()
        {
            TblStudents = new HashSet<TblStudents>();
            Tblschoolconfig = new HashSet<Tblschoolconfig>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<TblStudents> TblStudents { get; set; }
        public virtual ICollection<Tblschoolconfig> Tblschoolconfig { get; set; }
    }
}
