using System;
using System.Collections.Generic;

namespace iSchool.dbModels
{
    public partial class TblStudents
    {
        public int Id { get; set; }
        public string StdName { get; set; }
        public int Class { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string StdPic { get; set; }
        public string StdNumber { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string StdBform { get; set; }
        public int? Religion { get; set; }
        public string FatherName { get; set; }
        public string FatherCnic { get; set; }
        public string FatherNumber { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherIncome { get; set; }
        public string MotherName { get; set; }
        public string MotherCnic { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherIncome { get; set; }
        public string MotherPhone { get; set; }
    }
}
