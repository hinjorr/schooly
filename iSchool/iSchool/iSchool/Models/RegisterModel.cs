namespace iSchool.Repository
{
    using iSchool.dbModels;
    using iSchool.Models;
    using System;
    using System.Linq;
    using System.Net.Mail;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="RegisterModel" />.
    /// </summary>
    public class RegisterModel : IRegister
    {

        public readonly AMCDbContext _db;
        public RegisterModel(AMCDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Registeraion(SignupModel model)
        {
            try
            {
                TblRegistration tbl = new TblRegistration();
                tbl.CreatedDate = DateTime.Now;
                tbl.Email = model.Email;
                tbl.Ip = model.Ip;
                tbl.IsActive = true;
                tbl.Password = model.Password;
                _db.TblRegistration.Add(tbl);
                await _db.SaveChangesAsync();
                await Email(model);
                return true;

            }
            catch (Exception wx)
            {
                return false;
                throw;
            }
        }
        public async Task<bool> Email(SignupModel model)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("masoodarif1313@gmail.com");
                mail.To.Add(model.Email);
                mail.Subject = "iSchooly Registration";
                mail.Body = model.Email;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("masoodarif1313@gmail.com", "##masoodarif1050");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Emailcheck(SignupModel model)
        {
            try
            {
                var getemail = _db.TblRegistration.Where(x => x.Email == model.Email).FirstOrDefault();
                if (getemail !=null)
                {
                   return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
