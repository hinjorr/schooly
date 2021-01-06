using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class GeneralController : Controller
    {
        public readonly IGeneral _repogeneral;
        public GeneralController(IGeneral repogeneral)
        {
            _repogeneral = repogeneral;
        }
        public async Task<IActionResult> ListCountries()
        {
            var data = await _repogeneral.ListCountries();
            return Ok(data);
        }
    }
}
