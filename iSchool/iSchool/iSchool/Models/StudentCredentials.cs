using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Repository;

namespace iSchool.Models
{
    
    public class StudentCredentials:IStudent
    {
        public readonly AMCDbContext _db;
        public StudentCredentials(AMCDbContext db)
        {
            _db=db;
        }

        public async Task<bool> Addstudent(StudentModel model)
        {
            try
            {
             TblStudents tbl=new TblStudents();
             tbl.StdName=model.StdName;
             tbl.Class=model.Class;
             tbl.Address=model.Address;
             tbl.Country=model.Country;
             tbl.AdmissionDate=DateTime.Now;
             tbl.StdPic=model.StdPic;
             tbl.StdNumber=model.StdNumber;
             tbl.Dob=model.Dob;
             tbl.Gender=model.Gender;
             tbl.StdBform=model.StdBform;
             tbl.Religion=model.Religion;
             tbl.FatherName=model.FatherName;
             tbl.FatherCnic=model.FatherCnic;
             tbl.FatherNumber=model.FatherNumber;
             tbl.FatherOccupation=model.FatherOccupation;
             tbl.FatherIncome=model.FatherIncome;
             tbl.MotherIncome=model.MotherIncome;
             tbl.MotherCnic=model.MotherCnic;
             tbl.MotherOccupation=model.MotherOccupation;
             tbl.MotherName=model.MotherName;
             tbl.MotherPhone=model.MotherPhone;
             _db.TblStudents.Add(tbl);
            await  _db.SaveChangesAsync();
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
