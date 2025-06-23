using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_GYM.Models;

namespace ProyectoFinal_GYM.Controllers
{
    public class HomeController : Controller
    {

        private GymContext context = new GymContext();
        //public HomeController()
        //{
        //    if (!context.planes.Any())
        //    {

        //        // Crear actividades
        //        var natacion = new Actividad { nombre = "Natacion", duracion = 1, precio = 100, capacidad = 10 };
        //        var crossfit = new Actividad { nombre = "Crossfit", duracion = 1, precio = 200, capacidad = 40 };
        //        var boxeo = new Actividad { nombre = "Boxeo", duracion = 1, precio = 500, capacidad = 2 };
        //        var yoga = new Actividad { nombre = "Yoga", duracion = 1, precio = 1000, capacidad = 20 };
        //        var calistenia = new Actividad { nombre = "Calistenia", duracion = 1, precio = 1500, capacidad = 20 };

        //        // Guardar actividades primero
        //        context.actividades.AddRange(natacion, crossfit, boxeo, yoga, calistenia);
        //        context.SaveChanges();

        //        var planBasico = new Plan
        //        {
        //            nombre = "Basico",
        //            actividades = new List<Actividad> { natacion, crossfit, boxeo }
        //        };

        //        var planPremium = new Plan
        //        {
        //            nombre = "Premium",
        //            actividades = new List<Actividad>{ natacion,crossfit,boxeo,yoga,calistenia}
        //        };

        //        context.planes.AddRange(planBasico, planPremium);
        //        context.SaveChanges();
        //    }
        //}

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult registro()
        {
            return View();
        }

        public IActionResult SobreNosotros()
        {
            return View();
        }

        public IActionResult GuardarCliente(string nombre, string apellido, string documento, string genero)
        {
            {
                TempData["nombre"] = nombre;
                TempData["apellido"] = apellido;
                TempData["documento"] = documento;
                TempData["genero"] = genero;
            }
            return RedirectToAction("SeleccionDePlan");
        }

        public IActionResult SeleccionDePlan()
        {
            return View();
        }

        public IActionResult FinalizarRegistro(string plan)
        {
            string nombre = TempData["nombre"]?.ToString();
            string apellido = TempData["apellido"]?.ToString();
            string documento = TempData["documento"]?.ToString();
            string genero = TempData["genero"]?.ToString();

            var planSeleccionado = context.planes.FirstOrDefault(p => p.nombre.ToLower() == plan.ToLower());


            var cliente = new Cliente
            {
                nombre = nombre,
                apellido = apellido,
                documento = documento,
                genero = genero,
                plan = planSeleccionado
            };
            context.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}