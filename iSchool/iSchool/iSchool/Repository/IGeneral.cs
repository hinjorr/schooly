using iSchool.DTO;
using iSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Repository
{
    public interface IGeneral
    {
        public Task<List<ModelDropDown>> ListCountries();
        public Task<List<ModelDropDown>> ListReligions();
        public Task<List<ModelDropDown>> ListClass();
        public Task<List<ModelDropDown>> ListSubjects();



        // ModelDropDown        string
    }
}
