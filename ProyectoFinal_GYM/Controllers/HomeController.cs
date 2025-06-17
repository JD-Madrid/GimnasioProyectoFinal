using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_GYM.Models;

namespace ProyectoFinal_GYM.Controllers
{
    public class HomeController : Controller
    {

        GymContext context = new GymContext();
        public IActionResult Index()
        {
            return View();
        }
    }


}