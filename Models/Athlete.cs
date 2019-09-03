using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NextLevel.Models
{
    public class Athlete
    {
        [Key]
        public int Age { get; set; }
        public int GradeLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SchoolName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Postion { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

    }
}