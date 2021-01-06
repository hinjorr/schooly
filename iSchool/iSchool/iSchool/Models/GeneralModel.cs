using iSchool.dbModels;
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
        public async Task<List<ModelDropDown>> ListCountries()
        { // Ilist , List , Ienumerable
            List<ModelDropDown> data = await _db.TblCountries.Select(x => new ModelDropDown
            {
                Id = x.Id,
                text= x.CountryName,
                CountryCode= x.CountryCode
            }).ToListAsync();
            return data;
        }
    }
}
