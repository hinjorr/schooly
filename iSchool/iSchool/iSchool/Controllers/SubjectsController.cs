using iSchool.DTO;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class SubjectsController : Controller
    {
        public readonly ISubjects _repo;
        public SubjectsController(ISubjects repo)
        {
            _repo=repo;
        }
        public IActionResult GetSubject()
        {
            return View();
        }
        public async Task<IActionResult> PostSubject(SubjectsDTO model)
        {
            var data= await _repo.AddSubject(model);
            if (data==true)
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
