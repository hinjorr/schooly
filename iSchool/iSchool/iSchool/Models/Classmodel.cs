using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Repository;

namespace iSchool.Models
{
    public class Classmodel : IClass
    {
        public readonly AMCDbContext _db;
        public Classmodel(AMCDbContext db)
        {
            _db=db;
        }
        public async Task<bool> Addclass(ClassDTO model)
        {
            try
            {
                TblClass tbl=new TblClass();
                tbl.CFees=model.CFees;
                tbl.CName=model.CName;
                _db.TblClass.Add(tbl);
               await _db.SaveChangesAsync();
               return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }
}
