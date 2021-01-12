using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.DTO;
using iSchool.Error_class;

namespace iSchool.Repository
{
   public interface IAssignSubject
    {
        public Task<MasoodError> AddAssignSubject (AssignSbjectsDTO model);
    }
}
