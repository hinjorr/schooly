using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblRegistration
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Ip { get; set; }
        public bool IsActive { get; set; }
    }
}
