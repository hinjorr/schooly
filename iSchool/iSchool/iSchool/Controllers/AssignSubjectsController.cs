using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSchool.DTO;
using iSchool.Error_class;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;

namespace iSchool.Controllers
{
    public class AssignSubjectsController : Controller
    {
        public readonly IAssignSubject _repo;
        public AssignSubjectsController(IAssignSubject repo)
        {
            _repo=repo;
        }
        public IActionResult GetAssignedSubjects()
        {
            return View();
        }
        public async Task<IActionResult> PostAssignedSubjects(AssignSbjectsDTO model)
        {
            MasoodError obj=new MasoodError();
             obj=await _repo.AddAssignSubject(model);

            if (obj.check==true)
            {
                return Json(true);
            }
            else
            {
                return Json(obj);
            }
        }
    }
}

