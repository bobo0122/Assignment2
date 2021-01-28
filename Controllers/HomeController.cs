using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // this is how you do exception handling
            //throw new IndexOutOfRangeException();
            return View();
        }

        //To open this FanMail page, type /Home/Fanmail after the localhost

        [HttpGet("FanMail")]

        public IActionResult FanMail()
        {
            // this is how you do exception handling
            //throw new IndexOutOfRangeException();
            return View();
        }

        [HttpPost("FanMail")]

        public IActionResult FanMail(FanMailModel model)
        {
            double numericGrade = model.Assignments * 0.5 + model.Group * 0.1 + model.Quizzes * 0.1 +
                +model.Exams * 0.2 + model.INTEX * 0.1;
			string letterGrade = "";
			//if statements to see which letter grade they get
			if (numericGrade >= 94)
			{
				letterGrade = "A";
			}
			else if (numericGrade >= 90)
			{
				letterGrade = "A-";
			}
			else if (numericGrade >= 87)
			{
				letterGrade = "B+";
			}
			else if (numericGrade >= 84)
			{
				letterGrade = "B";
			}
			else if (numericGrade >= 80)
			{
				letterGrade = "B-";
			}
			else if (numericGrade >= 77)
			{
				letterGrade = "C+";
			}
			else if (numericGrade >= 74)
			{
				letterGrade = "C";
			}
			else if (numericGrade >= 70)
			{
				letterGrade = "C-";
			}
			else if (numericGrade >= 67)
			{
				letterGrade = "D+";
			}
			else if (numericGrade >= 64)
			{
				letterGrade = "D";
			}
			else if (numericGrade >= 60)
			{
				letterGrade = "D-";
			}
			else
			{
				letterGrade = "E";
			}
			@ViewBag.Grade = "your numeric grade is: " + numericGrade + "\n your letter grade is: " + letterGrade;
			return View("FanMail");
		}


    }
}
