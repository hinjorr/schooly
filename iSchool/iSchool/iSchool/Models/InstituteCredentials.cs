using iSchool.dbModels;
using iSchool.DTO;
using iSchool.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Models
{
    public class InstituteCredentials : IInstitue
    {
        public readonly AMCDbContext _db;
        public InstituteCredentials(AMCDbContext db)
        {
            _db = db;
        }
        public async Task<bool> addinstitute(InstituteModel model)
        {
            try
            {

                Tblschoolconfig tbl = new Tblschoolconfig();
                tbl.Address = model.Address;
                tbl.Admissionfee = model.Admissionfee;
                tbl.Logo = model.Logo;
                tbl.Name = model.Name;
                tbl.Moto = model.Moto;
                tbl.Phone = model.Phone;
                tbl.Website = model.Website;
                tbl.Address = model.Admissionfee;
                tbl.RulesRegulations = model.RulesRegulations;
                tbl.Country = model.Country;
                _db.Tblschoolconfig.Add(tbl);
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
