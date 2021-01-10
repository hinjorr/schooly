using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblSubject
    {
        public TblSubject()
        {
            TblAssignclass = new HashSet<TblAssignclass>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<TblAssignclass> TblAssignclass { get; set; }
    }
}
