using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblClass
    {
        public TblClass()
        {
            TblAssignclass = new HashSet<TblAssignclass>();
            TblStudents = new HashSet<TblStudents>();
        }

        public int CId { get; set; }
        public string CName { get; set; }
        public int? CFees { get; set; }

        public virtual ICollection<TblAssignclass> TblAssignclass { get; set; }
        public virtual ICollection<TblStudents> TblStudents { get; set; }
    }
}
