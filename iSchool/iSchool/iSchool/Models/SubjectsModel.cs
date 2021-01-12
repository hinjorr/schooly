using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Repository;

namespace iSchool.Models
{
    public class SubjectsModel : ISubjects
    {
        public readonly AMCDbContext _db;
        public SubjectsModel(AMCDbContext db)
        {
            _db=db;
        }
        
        public async Task<bool> AddSubject(SubjectsDTO model)
        {
            try
            {
                TblSubject tbl=new TblSubject();
                tbl.SubjectName=model.SubjectName;
                _db.TblSubject.Add(tbl);
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
