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
        public async Task<IActionResult> ListReligions()
        {
            var data=await _repogeneral.ListReligions();
            return Ok(data);
        }

        public async Task<IActionResult> ListClass()
        {
            var data = await _repogeneral.ListClass();
            return Ok(data);
        }
        public async Task<IActionResult> ListSubjects()
        {
            var data = await _repogeneral.ListSubjects();
            return Ok(data);
        }
    }
}
