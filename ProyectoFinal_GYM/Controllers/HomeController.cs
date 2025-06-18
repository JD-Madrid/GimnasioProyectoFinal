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
    
 
    public IActionResult registro()
        {
            return View();
        }

    public IActionResult GuardarCliente(string nombre, string apellido, string documento, string genero)
        {
            var cliente = new Cliente
            {
                nombre = nombre,
                apellido = apellido,
                documento = documento, 
                genero = genero
            };
            context.clientes.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}