using iSchool.DTO;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class InstituteController : Controller
    {
        public readonly IInstitue _repo;
        
        public InstituteController(IInstitue repo)
        {
            _repo = repo;
           
        }
        public IActionResult GetInstitute()
        {
            return View();
        }
        public async Task<IActionResult> PostInstitue(InstituteModel model)
        {
            var chk = await _repo.addinstitute(model);
            if (chk == true)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }

        }

        

    }
}
