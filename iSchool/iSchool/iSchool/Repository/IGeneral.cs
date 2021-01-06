using iSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Repository
{
  public  interface IGeneral
    {
        public Task<List<ModelDropDown>> ListCountries();

        // ModelDropDown        string
    }
}
