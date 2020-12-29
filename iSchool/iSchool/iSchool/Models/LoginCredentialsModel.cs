using iSchool.dbModels;
using iSchool.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Models
{
    public class LoginCredentialsModel : ILogin
    {
        public readonly AMCDbContext _db;
        public LoginCredentialsModel(AMCDbContext db)
        {
           _db= db;
        }
        public  bool GetLogin(LoginModel model)
        {
             try
             {
                var loginchk= _db.Tblregistration.Where(x =>x.Email==model.Email && x.Password==model.Password).FirstOrDefault();                 
                if (loginchk !=null)
                {
                    return true;
                }  
                else
                {
                    return false;
                }          
             }
             catch (Exception ex)
             {
                 
                 throw;
             }
        }
    }
}
