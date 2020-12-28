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
                Tblregistration tbl = new Tblregistration();
                tbl.CreatedDate = DateTime.Now;
                tbl.Email = model.Email;
                tbl.Ip = model.Ip;
                tbl.IsActive = 1;
                tbl.Password = model.Password;
                _db.Tblregistration.Add(tbl);
                await _db.SaveChangesAsync();
                 Email(model);
                return true;

            }
            catch (Exception wx)
            {
                return false;
                throw;
            }
        }
        public  bool Email(SignupModel model)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("masoodarif1313@gmail.com");
                mail.To.Add(model.Email);
                mail.Subject = "iSchooly Registration";
                mail.IsBodyHtml = true;
                mail.Body = @"<html> <head> <meta http-equiv=Content-Type content='text/html; charset=utf-8'> <meta name=Generator content='Microsoft Word 15 (filtered medium)'> <title>Nimblur</title> <style> <!-- /* Font Definitions */ @font-face {font-family:Helvetica; panose-1:2 11 6 4 2 2 2 2 2 4;} @font-face {font-family:'Cambria Math'; panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face {font-family:Calibri; panose-1:2 15 5 2 2 2 4 3 2 4;} @font-face {font-family:Georgia; panose-1:2 4 5 2 5 4 5 2 3 3;} /* Style Definitions */ p.MsoNormal, li.MsoNormal, div.MsoNormal {margin:0in; margin-bottom:.0001pt; line-height:normal; font-size:12.0pt; font-family:'Times New Roman',serif; color:windowtext;} a:link, span.MsoHyperlink {mso-style-priority:99; color:#119DCB; text-decoration:none none;} a:visited, span.MsoHyperlinkFollowed {mso-style-priority:99; color:#119DCB; text-decoration:none none;} p {mso-style-priority:99; mso-margin-top-alt:auto; margin-right:0in; mso-margin-bottom-alt:auto; margin-left:0in; line-height:18.0pt; font-size:12.0pt; font-family:'Helvetica',sans-serif; color:#45474D;} p.externalclass, li.externalclass, div.externalclass {mso-style-name:externalclass; mso-margin-top-alt:auto; margin-right:0in; mso-margin-bottom-alt:auto; margin-left:0in; line-height:normal; font-size:12.0pt; font-family:'Helvetica',sans-serif; color:#45474D;} p.backgroundtable, li.backgroundtable, div.backgroundtable {mso-style-name:backgroundtable; margin:0in; margin-bottom:.0001pt; line-height:normal; font-size:12.0pt; font-family:'Helvetica',sans-serif; color:#45474D;} p.imagefix, li.imagefix, div.imagefix {mso-style-name:image_fix; mso-margin-top-alt:auto; margin-right:0in; mso-margin-bottom-alt:auto; margin-left:0in; line-height:18.0pt; font-size:12.0pt; font-family:'Helvetica',sans-serif; color:#45474D;} p.padding-wide-image, li.padding-wide-image, div.padding-wide-image {mso-style-name:padding-wide-image; mso-margin-top-alt:auto; margin-right:0in; mso-margin-bottom-alt:auto; margin-left:0in; line-height:18.0pt; font-size:12.0pt; font-family:'Helvetica',sans-serif; color:#45474D;} span.EmailStyle23 {mso-style-type:personal-reply; font-family:'Calibri',sans-serif; color:#1F497D;} .MsoChpDefault {mso-style-type:export-only; font-size:10.0pt;} @page WordSection1 {size:8.5in 11.0in; margin:1.0in 1.0in 1.0in 1.0in;} div.WordSection1 {page:WordSection1;} --> </style> <!--[if gte mso 9]> <xml> <o:shapedefaults v:ext='edit' spidmax='1026' /> </xml> <![endif]--><!--[if gte mso 9]> <xml> <o:shapelayout v:ext='edit'> <o:idmap v:ext='edit' data='1' /> </o:shapelayout> </xml> <![endif]--> </head> <body lang=EN-US link='#119DCB' vlink='#119DCB' style='background:#F3F3F3;'> <div id=Header> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width='100%' style='width:100.0%;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width='100%' style='width:100.0%;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:6.25in;background:#000000;border-collapse:collapse'> <tr style='height:163.5pt'> <td width=600 style='width:6.25in;padding:0in 0in 0in 0in;height:163.5pt'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:6.25in;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:375.0pt;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:375.0pt;border-collapse:collapse'> <tr> <td style='padding:30.0pt 0in 10.0pt 0in'> <p class=MsoNormal align=center style='text-align:center'> <span style='color:white'><img border=0 width=200 height=60 id='_x0000_i1025' alt='Nimblur' src='paramLogo'></span> </p> </td> </tr> </table> </div> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:375.0pt;border-collapse:collapse'> <tr> <td > <p class=MsoNormal align=center style='text-align:center;line-height:24.0pt;height:70.0pt'> <span style='font-size:19.5pt;font-family:Helvetica,sans-serif;color:white'> paramTitle <o:p></o:p> </span></p> </td> </tr> </table> </div> </td> </tr> </table> </div> </td> </tr> </table> </div> </td> </tr> </table> </div> </td> </tr> </table> </td> </tr> </table> </div> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 style='width:100.0%;;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:6.25in;background:white;border-collapse:collapse'> <tr> <td style='padding:0in 0in 0in 0in'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:375.0pt;background:white;border-collapse:collapse'> <tr> <td style='padding:0in 0in 30.0pt 0in;-webkit-font-smoothing: antialiased'></td> </tr> </table> </div> <div id=Body> <p class=MsoNormal align=center style='text-align:center'> <o:p>&nbsp;</o:p> </p> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 style='border-collapse:collapse;'> <tr> <td style='padding:0in 0in 0in 0in;-webkit-font-smoothing:antialiased'> <div align=center> <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=0 style='width:375.0pt;background:white;border-collapse:collapse;-webkit-font-smoothing:antialiased'> <tr> <td style='padding:0in 0in 30.0pt 0in'> <p align=center style='text-align:paramAlign'> <strong> <span style='font-family:'Helvetica',sans-serif'>paramName</span></strong> </p> <p align=center style='text-align:paramAlign'> paramFirstDescription </p> <p align=center style='text-align:left'> paramSecondDescription </p> <p align=center style='text-align:left'> <strong><span style='font-family:'Helvetica',sans-serif'>Thanks, <br> Nimblur Team</span></strong> </p> </td> </tr> </table> </div> </td> </tr> </table> </div> </div> </td> </tr> </table> </div> </td> </tr> </table> </div> </body> </html>";
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
                var getemail = _db.Tblregistration.Where(x => x.Email == model.Email).FirstOrDefault();
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
