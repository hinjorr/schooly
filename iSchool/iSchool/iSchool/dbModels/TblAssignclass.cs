using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblAssignclass
    {
        public int AssignclassId { get; set; }
        public int? SubjectId { get; set; }
        public int? CId { get; set; }
        public int? MarksWeightage { get; set; }

        public virtual TblClass C { get; set; }
        public virtual TblSubject Subject { get; set; }
    }
}
