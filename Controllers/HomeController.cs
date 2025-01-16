using LabHelloMvc.Models; 
using Microsoft.AspNetCore.Mvc; 

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Vinny",
                LastName = "Wu",
                StudentId = "W0496645"

            };

            return View(person); 
        }
    }
}
