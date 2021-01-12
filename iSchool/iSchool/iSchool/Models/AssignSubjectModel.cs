using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Error_class;
using iSchool.Repository;

namespace iSchool.Models
{
    public class AssignSubjectModel : IAssignSubject
    {
        public readonly AMCDbContext _db;
        public AssignSubjectModel(AMCDbContext db)
        {
            _db=db;
        }
        public async Task<MasoodError> AddAssignSubject(AssignSbjectsDTO model)
        {
            MasoodError obj=new MasoodError();
            try
            {
                TblAssignclass tbl=new TblAssignclass();
                tbl.SubjectId=model.SubjectId;
                tbl.CId=model.CId;
                tbl.MarksWeightage=model.MarksWeightage;
                _db.TblAssignclass.Add(tbl);
                await _db.SaveChangesAsync();
                obj.check=true;
                return obj;
            }
            catch (Exception ex)
            {
                
                obj.erroname=ex.InnerException.InnerException.Message.ToString();
                return obj; 
                throw;
            }
        }
    }
}
