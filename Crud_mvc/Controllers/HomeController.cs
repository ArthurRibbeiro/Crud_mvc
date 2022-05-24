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
        public ActionResult Lista (int pessoaId, string nome, string cpf, string email, string tel)
        {
            ViewData["pessoaId"] = pessoaId;
            ViewData["nome"] = nome;
            ViewData["cpf"] = cpf;
            ViewData["email"] = email;
            ViewData["tel"] = tel;

            String salvar = (pessoaId + ";" + nome + ";" + cpf + ";" + email + ";" + tel);
            ViewData["salvar"] = salvar;
            SavePessoa.Criar();
            SavePessoa.Salvar(salvar);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
