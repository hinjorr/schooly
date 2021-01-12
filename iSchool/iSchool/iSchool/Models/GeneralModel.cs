using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Models
{
    public class GeneralModel : IGeneral
    {
        public readonly AMCDbContext _db;
        public GeneralModel(AMCDbContext db)
        {
            _db = db;
        }

        public async Task<List<ModelDropDown>> ListClass()
        {
            List<ModelDropDown> data = await _db.TblClass.Select(x => new ModelDropDown
            {
                CId = x.CId,
                CName = x.CName
            }).ToListAsync();
            return data;
        }

        public async Task<List<ModelDropDown>> ListCountries()
        { // Ilist , List , Ienumerable
            List<ModelDropDown> data = await _db.TblCountries.Select(x => new ModelDropDown
            {
                CountryId = x.CountryId,
                CountryName= x.CountryName,
                
            }).ToListAsync();
            return data;
        }

        public async Task<List<ModelDropDown>> ListReligions()
        {
            List<ModelDropDown> data=await _db.TblReligion.Select(x => new ModelDropDown
            {
                ReligionId=x.ReligionId,
                Religion=x.Religion
            }).ToListAsync();
            return data;
        }

        public async Task<List<ModelDropDown>> ListSubjects()
        {
            List<ModelDropDown> data= await _db.TblSubject.Select(x => new ModelDropDown
            {
                SubjectId=x.SubjectId,
                SubjectName=x.SubjectName

            }).ToListAsync();
            return data;
        }
    }
}
