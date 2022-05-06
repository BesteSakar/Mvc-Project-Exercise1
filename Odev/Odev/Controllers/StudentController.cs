using Microsoft.AspNetCore.Mvc;
using Odev.Models;
using System.Collections.Generic;

namespace Odev.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetStudent()
        {
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
               
               
            }

            return View();
           
        }



    public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { StudentName = "Beste",StudentSurname="Sakar",StudentEmail="Beste@gmail.com"}
            };
            return View(students);
        }
    }
}
