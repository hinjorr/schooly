using iSchool.DTO;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class StudentController : Controller
    {
        public readonly IStudent _repo;
        public StudentController(IStudent repo)
        {
            _repo=repo;
        }
        public IActionResult GetStudent()
        {
            return View();
        }

        public async Task<IActionResult> PostStudent(StudentModel model)
        {
            var chk=await _repo.Addstudent(model);
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
