using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sampledata.Models;
namespace Sampledata.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{Id=1,Name="dawood"},
                 new Student{Id=1,Name="dawood"}
            };
            return View(students);
        }
    }
}