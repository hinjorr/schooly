namespace iSchool.Controllers
{
    using iSchool.DTO;
    using iSchool.Models;
    using iSchool.Repository;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    using System.Threading.Tasks;

    public class SignUpController : Controller
    {
        public readonly IRegister _repo;
        public SignUpController(IRegister repo)
        {
            _repo = repo;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public async Task<IActionResult> Signuped(SignupModel model)
        {
            //getting client ip
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST             
            string myIP = Dns.GetHostEntry(hostName).AddressList[1].ToString();
            model.Ip = myIP;

            //putting the model in registration method
            var data =await _repo.Registeraion(model);
            return Ok(data);    
        }

        public IActionResult emailcheck(SignupModel model)
        {
            var chk =  _repo.Emailcheck(model);
            return Ok(chk);
        }

       

        


    }
}
