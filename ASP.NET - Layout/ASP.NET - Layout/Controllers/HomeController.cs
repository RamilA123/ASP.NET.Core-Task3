using ASP.NET___Layout.Models;
using ASP.NET___Layout.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ASP.NET___Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();


            //Student stu1 = new()
            //{
            //    Id = 1,
            //    FullName = "Ramil Allahverdiyev",
            //    Address = "Azadliq",
            //    Age = 26
            //};

            //Student stu2 = new()
            //{
            //    Id = 2,
            //    FullName = "Elcan Musali",
            //    Address = "Inqilab",
            //    Age = 20
            //};

            //Student stu3 = new()
            //{
            //    Id = 3,
            //    FullName = "Yunis Balakisiyev",
            //    Address = "Nizami",
            //    Age = 21
            //};

            //Student stu4 = new()
            //{
            //    Id = 4,
            //    FullName = "Selim Agamaliyev",
            //    Address = "Sumqayit",
            //    Age = 25
            //};

            //Student stu5 = new()
            //{
            //    Id = 5,
            //    FullName = "Ulfet Mirzeyev",
            //    Address = "Neftciler",
            //    Age = 23
            //};


            //string logo = "Site logo";
            //List<Student> students = new List<Student>() { stu1, stu2, stu3, stu4, stu5 };
            //Slider slider = new()
            //{
            //    Id = 1,
            //    Image = "https://graywolfconsulting.com/wp-content/uploads/2017/06/slider-nyc.jpg"
            //};

            //HomeVM model = new()
            //{
            //    Logo = logo,
            //    Students = students,
            //    Slider = slider
            //};

            //ViewData["Name"] = "Resul";
            //ViewData["nums"] = new int[] {1,2,3,4,5,6,7,8};
            //ViewBag.surname = "Hesenov";
            //TempData["address"] = "Xalqlar dostlugu";
        }

        //public IActionResult Detail()
        //{
        //     return View();
        //}
    }
}
