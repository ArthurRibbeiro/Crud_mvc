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


        [HttpPost]
        public ActionResult Lista (Pessoa pessoa)
        {
            var pessoa = new Pessoa(nome, sobrenome, cpf, nasc, sexo);

           

            ViewData["codNome"] = pessoa.getValNome();
            ViewData["codSobrenome"] = pessoa.getValSobrenome();
            ViewData["codCPF"] = pessoa.getValCPF();
            ViewData["codNasc"] = pessoa.getValNasc();



            ViewData["nome"] = pessoa.getNome();
            ViewData["sobrenome"] = pessoa.getSobrenome();
            ViewData["cpf"] = pessoa.getCPF();
            ViewData["nasc"] = pessoa.getNasc();
            ViewData["idade"] = pessoa.getIdade();
            ViewData["sexo"] = pessoa.getSexo();


            return View("Cadastro");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool ValidarModel(Pessoa pessoa)
        {
            return true;
        }

    }
}
