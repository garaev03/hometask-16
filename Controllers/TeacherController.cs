using hometask_16.Models;
using Microsoft.AspNetCore.Mvc;

namespace hometask_16.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id = 1,
                    Name = "Zahid",
                    Surname="Məmmədli",
                    Age = 22,
                    GroupNo= "BB-202",
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Əhəd",
                    Surname="Tağıyev",
                    Age = 23,
                    GroupNo= "BB-202",
                }
            };

            return View(teachers);
        }
    }
}
