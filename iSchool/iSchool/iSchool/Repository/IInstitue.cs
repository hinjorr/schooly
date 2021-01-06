using iSchool.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Repository
{
   public interface IInstitue
    {
        public  Task<bool> addinstitute(InstituteModel model);
       
    }
}
