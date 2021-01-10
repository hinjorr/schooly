using iSchool.DTO;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class ClassController : Controller
    {
        public readonly IClass _repo;
        public ClassController(IClass repo)
        {
            _repo=repo;
        }
        public IActionResult GetClass()
        {
            return View();
        }
        public async Task<IActionResult> PostClass(ClassDTO model)
        {
            var chk=await _repo.Addclass(model);
            if (chk==true)
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
