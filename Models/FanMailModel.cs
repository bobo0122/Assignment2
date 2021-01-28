using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class FanMailModel
    {
        [Required]
        [Range(1, 100)]
        public Double Assignments { get; set; }
        [Required]
        [Range(1, 100)]
        public Double Group { get; set; }
        [Required]
        [Range(1, 100)]
        public Double Quizzes { get; set; }
        [Required]
        [Range(1, 100)]
        public Double Exams { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Out of range")]
        public Double INTEX { get; set; }
        
    }
        
   
}

