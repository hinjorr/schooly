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
                tbl.Logo = model.Logo;
                tbl.Name = model.Name;
                tbl.Address = model.Address;
                tbl.CountryId = model.CountryId;
                tbl.Phone = model.Phone;
                tbl.Moto = model.Moto;
                tbl.Website = model.Website;
                tbl.AdmissionFee = model.AdmissionFee;
                tbl.RulesRegulations=model.RulesRegulations;
                tbl.TransportFee=model.TransportFee;
                tbl.BooksFee=model.BooksFee;
                tbl.FineFee=model.FineFee; 
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
