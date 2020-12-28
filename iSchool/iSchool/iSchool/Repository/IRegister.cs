using iSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Repository
{
    public interface IRegister
    {
        Task<bool> Registeraion(SignupModel model);
        Task<bool> Email(SignupModel model);

        bool Emailcheck(SignupModel model);


    }
}
