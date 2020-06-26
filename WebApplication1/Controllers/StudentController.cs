using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Student> StudentList = new List<Student>();
            Student s1 = new Student();
            s1.Id = Guid.NewGuid().ToString();
            s1.Name = "liya";
            s1.M1 = 20;
            s1.M2 = 20;
            s1.M3 = 20;

            Student s2 = new Student();
            s2.Id = Guid.NewGuid().ToString();
            s2.Name = "anu";
            s2.M1 = 20;
            s2.M2 = 20;
            s2.M3 = 20;

            Student s3 = new Student();
            s3.Id = Guid.NewGuid().ToString();
            s3.Name = "vivek";
            s3.M1 = 20;
            s3.M2 = 20;
            s3.M3 = 20;


            StudentList.Add(s1);
            StudentList.Add(s2);
            StudentList.Add(s3);









            return View(StudentList);
        }
    }
}
