using DEPI_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DEPI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeModel home = new HomeModel
            {
                Id = 1 ,
                Name = "Ammar Yasser",
                Description = "A Backend Developer specializing in .NET Core. I create scalable and efficient solutions for web applications."
            };
            return View(home);
        }
        public IActionResult Skills()
        {
            Skills skills1 = new Skills
            {
                Name = "Database Design",
                Description = "How to make diagrams and map DB",
                Image = "/img/DBD.png" 
            };
            Skills skills2 = new Skills
            {
                Name = "MsSQL Server",
                Description = "Create and manage databases",
                Image = "/img/MSSQLServer.png"
            };
            Skills skills3 = new Skills
            {
                Name = "C#",
                Description = "Mastering C# - OOP - Advanced topics",
                Image = "/img/c-1.png"
            };
            Skills skills4 = new Skills
            {
                Name = "LINQ",
                Description = "Query data using C#",
                Image = "/img/LINQ.png"
            };
            Skills skills5 = new Skills
            {
                Name = "EF Core",
                Description = "Entity Framework Core",
                Image = "/img/EF.png"
            };
            Skills skills6 = new Skills
            {
                Name = "MVC",
                Description = "Model - View - Controller pattern",
                Image = "/img/MVC.jpg"
            };

            List<Skills> skills = new List<Skills>()
    {
        skills1, skills2, skills3, skills4, skills5, skills6
    };
            return View(skills);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Projcts()
        {
            Projects project1 = new Projects()
            {
                Name = "E-Commerce in MVC ",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",
                
            };
            Projects project2 = new Projects()
            {
                Name = "E-Commerce in API ",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",

            };
            Projects project3 = new Projects()
            {
                Name = "Library system ",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",

            };
            Projects project4 = new Projects()
            {
                Name = "GYM System",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",

            };
            Projects project5 = new Projects()
            {
                Name = "CURD Operations",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",

            };
            Projects project6 = new Projects()
            {
                Name = "E-Commerce",
                Description = "Online E-Commerce /n Tools: C# , SQLServer ,LINQ , EF Core , MVC , N-Tiers  ",
                link = "https://github.com/Ammar-Yasser8/E-Commerce-Store-MVC-.NET-Core",

            };
            List<Projects> pro = new List<Projects>
            {
                project1,project2 ,project3 ,project4 ,project5,project6
            };
            return View(pro);
        }
        public IActionResult ContactUs()
        {
            var contactInfo = new Contact
            {
                PhoneNumber = "01127080264",
                Email = "ammar.yasser8920@gmail.com",
                LinkedIn = "https://www.linkedin.com/in/ammar-yasser-a01772250/",
                GitHub = "https://github.com/Ammar-Yasser8"
            };

            return View(contactInfo);
        }







    }
}
