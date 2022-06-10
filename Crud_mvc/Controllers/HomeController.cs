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

        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public string verificaNome(string nome)
        {
            if (nome.Contains(" "))
            {
                return "Insira somente o primeiro nome, sem espaços";
            }else if (contemNumeros(nome) == true)
            {
                return "Insira um nome válido, sem números";

            }
            else
            {
                return "válido";
            }

        }

        public string verificaSobreome(string sobrenome)
        {
            if (contemNumeros(sobrenome) == true)
            {
                return "Insira um sobrenome válido, sem números";

            }else{
                return "válido";
            }

        }

        public string verificaCPF(string cpf)
        {
            if (contemLetras(cpf) == true)            {
                return "Insira um CPF válido, sem letras";

            }
            else
            {
                return "válido";
            }

        }

        public string corrigeNasc(string nasc)
        {
            return nasc.Split('-')[2] + '-' + nasc.Split('-')[1] + '-' + nasc.Split('-')[0];

        }





        [HttpPost]
        public ActionResult Lista (string nome, string sobrenome, string cpf, string nasc, string sexo)
        {
            ViewData["codNome"] = verificaNome(nome);
            ViewData["CodSobrenome"] = verificaSobreome(sobrenome);
            ViewData["CodCPF"] = verificaCPF(cpf);

            
            ViewData["nome"] = nome;
            ViewData["sobrenome"] = sobrenome;
            ViewData["cpf"] = cpf;
            ViewData["nasc"] = corrigeNasc(nasc);
            ViewData["sexo"] = sexo;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
