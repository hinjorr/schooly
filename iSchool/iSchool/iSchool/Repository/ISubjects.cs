using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.DTO;

namespace iSchool.Repository
{
   public interface ISubjects
    {
        public Task<bool> AddSubject(SubjectsDTO model);
    }
}
