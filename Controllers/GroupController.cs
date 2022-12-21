using hometask_16.Models;
using Microsoft.AspNetCore.Mvc;

namespace hometask_16.Controllers
{
    public class GroupController : Controller
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
        public IActionResult Index()
        {
            return View(groups);
        }
         
        public IActionResult No(int Id)
        {
            foreach (var item in groups)
            {   
                if(item.Id==Id)
                    return View(item);
            }

            return Json("error");
        }
    }
}
