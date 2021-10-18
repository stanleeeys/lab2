using lab2.Data;
using lab2.Dominio;
using lab2.Models;
using lab2.Models.ViewModels;
using lab2.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IPerson iperson;

        public HomeController(ILogger<HomeController> logger, IPerson iperson)
        {
            this.iperson = iperson;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Mostrar()
        {
            
            return View();
        }


        public IActionResult GetALL()
        {
            var DandoFormatoJson = iperson.ListarPersonas();


            return Json(new { data = DandoFormatoJson });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult Save(ViewModelPerson persona)

        {

            Person person = new Person();

            if (ModelState.IsValid)
            {


                if (persona.AgePerson >= 18)
                {
                    person.NamePerson = persona.NamePerson;
                    person.AgePerson = persona.AgePerson;
                    person.DescriptionPerson = persona.DescriptionPerson;

                    iperson.Save(person);
                    return View("Mostrar");


                }
                else
                {
                    
                    return Redirect("/Home/Save");
                }


            }
            else
            {
                Console.WriteLine("No puede ingresar");

                return View();

            }


        }
    }
}
