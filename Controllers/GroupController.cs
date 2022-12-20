using hometask_16.Models;
using Microsoft.AspNetCore.Mvc;

namespace hometask_16.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            List<Group> groups = new()
            {
                new Group
                {
                    Id = 1,
                    Name= "Back-End Full Stack",
                    GroupNo="BB-201"
                },
                new Group
                {
                    Id = 2,
                    Name= "Back-End Full Stack",
                    GroupNo="BB-202"
                },
                new Group
                {
                    Id = 3,
                    Name= "Back-End Full Stack",
                    GroupNo="BB-203"
                },
                 new Group
                {
                    Id = 4,
                    Name= "Front-End Full Stack",
                    GroupNo="BF-201"
                },
                  new Group
                {
                    Id = 5,
                    Name= "Front-End Full Stack",
                    GroupNo="BB-203"
                },
                   new Group
                {
                    Id = 6,
                    Name= "Front-End Full Stack",
                    GroupNo="BB-203"
                },
            };
            return View(groups);
        }
    }
}
