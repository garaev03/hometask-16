using hometask_16.Models;
using Microsoft.AspNetCore.Mvc;

namespace hometask_16.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new()
            {
                new Student
                {
                    Id= 1,
                    Name="Əli",
                    Surname="Seyfullazadə",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 2,
                    Name="Ilahə",
                    Surname="Lətifova",
                    Grade=100,
                    Gender=false,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 3,
                    Name="Nəzrin",
                    Surname="Əsgərova",
                    Grade=100,
                    Gender=false,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 4,
                    Name="Murad",
                    Surname="Hacı",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 5,
                    Name="Sima",
                    Surname="Maniyeva",
                    Grade=100,
                    Gender=false,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 6,
                    Name="Gülgəz",
                    Surname="XXX",
                    Grade=100,
                    Gender=false,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 7,
                    Name="Əli",
                    Surname="İbrahimov",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 8,
                    Name="İlqar",
                    Surname="Niftəliyev",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 9,
                    Name="Amil",
                    Surname="Məmmədli",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 10,
                    Name="Mahmud",
                    Surname="XXX",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 11,
                    Name="Samir",
                    Surname="Qarayev",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
                new Student
                {
                    Id= 12,
                    Name="Seyhun",
                    Surname="XXX",
                    Grade=100,
                    Gender=true,
                    GroupNo="BB-202",
                },
            };

            return View(students);
        }
    }
}
