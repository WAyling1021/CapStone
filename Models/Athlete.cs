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
        public int age { get; set; }
        public int gradeLevel { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string schoolName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public string postion { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

    }
}