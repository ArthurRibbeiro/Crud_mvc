using Crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_mvc.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Lista (string nome, string sobrenome, string cpf, string nasc, string sexo)
        {
            
            ViewData["nome"] = nome;
            ViewData["sobrenome"] = sobrenome;
            ViewData["cpf"] = cpf;
            ViewData["nasc"] = nasc;
            ViewData["sexo"] = sexo;


            //System.IO.File.WriteAllText("","");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
