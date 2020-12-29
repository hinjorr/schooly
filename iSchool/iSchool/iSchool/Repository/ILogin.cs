using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.Models;

namespace iSchool.Repository
{
  public  interface ILogin
    {
        bool GetLogin(LoginModel model);
    }
}
