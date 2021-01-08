using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblReligion
    {
        public TblReligion()
        {
            TblStudents = new HashSet<TblStudents>();
        }

        public int ReligionId { get; set; }
        public string Religion { get; set; }

        public virtual ICollection<TblStudents> TblStudents { get; set; }
    }
}
