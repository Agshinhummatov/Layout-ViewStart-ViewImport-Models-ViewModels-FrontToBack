using Layout_ViewModels.Models;
using Layout_ViewModels.ViewModels.Home;
using Layout_ViewModels.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            #region Model to view

            //ViewData["names"] = new string [] { "Elcan","Pervin","Aqsin" };

            //ViewBag.numbers = new int[] { 1, 2, 5, 7, 10 };

            //List<int> numbers = new List<int>() { 1, 2, 5, 4 };

            //TempData["surname"] = "Qurbanov";


            // projecti run eden kimi hansi shefeye gedeceyini bu methodla teyin edirik icinde Detail gondermisik

            //return RedirectToAction(nameof(Detail));


            //string gondere bilmirik ona gorede casting edirik  object tipine

            //string name = "Xakker";

            //return View((object)name);


            //ViewBag.address = "Sumqayit";


            ////classlari yeni modellerimi bu cura gonderirem

            //Student stu1 = new Student
            //{
            //    Id = 1,
            //    FullName = "Pervin Rehimli",
            //    Age = 26

            //};


            //Student stu2 = new Student
            //{
            //    Id = 2,
            //    FullName = "Elcan Qurbanov",
            //    Age = 20

            //};



            //Student stu3 = new Student
            //{
            //    Id = 3,
            //    FullName = "Mirze Bashirzade",
            //    Age = 27

            //};


            //List<Student> students = new List<Student> { stu1, stu2, stu3 };

            //return View(students);



            #endregion



            Student stu1 = new Student
            {
                Id = 1,
                FullName = "Pervin Rehimli",
                Age = 26

            };


            Student stu2 = new Student
            {
                Id = 2,
                FullName = "Elcan Qurbanov",
                Age = 20

            };



            Student stu3 = new Student
            {
                Id = 3,
                FullName = "Mirze Bashirzade",
                Age = 27

            };


            List<Student> students = new List<Student> { stu1, stu2, stu3 };


            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count =50,
                Price = 200,
                Description = "Description"

            };

            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };

            HomeVM model = new()
            {
                Students = students,
                Product = productVM
            };

            return View(model);



        }



        //public IActionResult Detail()
        //{
        //    return View();
        //}
            
            


    }
}
