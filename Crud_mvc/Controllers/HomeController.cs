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
                return "Válido";
            }

        }

        public string verificaSobreome(string sobrenome)
        {
            if (contemNumeros(sobrenome) == true)
            {
                return "Insira um sobrenome válido, sem números";

            }else{
                return "Válido";
            }

        }

        public string verificaCPF(string cpf)
        {
            if (contemLetras(cpf) == true)            {
                return "Insira um CPF válido, sem letras";

            }
            else if (IsCpf(cpf) == true)
            {
                return "Válido";
            }
            else
            {
                return "Informe um CPF Válido";
            }
            

        }

        public string verificaNasc(string nasc)
        {
            bool valido = true;
            int dia = Convert.ToInt32(nasc.Split('-')[0]);
            int mes = Convert.ToInt32(nasc.Split('-')[1]);
            int ano = Convert.ToInt32(nasc.Split('-')[2]);
            var data = DateTime.Now;

            if (data.Year < ano)
            {
                valido = false;
            }else if (data.Year == ano && data.Month < mes)
            {
                valido = false;
            }else if (data.Year == ano && data.Month == mes && data.Day < dia)
            {
                valido = false;
            }else if (ano < (data.Year - 130))
            {
                valido = false;
            }


            if (valido)
            {
                return "Válido";
            }
            else
            {
                return "Insira uma data de nascimento válida";
            }
            

        }

        public string corrigeNasc(string nasc)
        {
            return nasc.Split('-')[2] + '-' + nasc.Split('-')[1] + '-' + nasc.Split('-')[0];

        }

        public int calcIdade(string nasc){

            int idade = DateTime.Now.Year - Convert.ToInt32(nasc.Split('-')[2]);

            if (DateTime.Now.Month < Convert.ToInt32(nasc.Split('-')[1]))
            {
                idade--;
            }else if (DateTime.Now.Month == Convert.ToInt32(nasc.Split('-')[1]))
            {
                if (DateTime.Now.Day < Convert.ToInt32(nasc.Split('-')[0]))
                {
                    idade--;
                }
            }
                return idade;
        }

        [HttpPost]
        public ActionResult Lista (string nome, string sobrenome, string cpf, string nasc, string sexo)
        {
            nasc = corrigeNasc(nasc);

            int idade = calcIdade(nasc);
            ViewData["codNome"] = verificaNome(nome);
            ViewData["codSobrenome"] = verificaSobreome(sobrenome);
            ViewData["codCPF"] = verificaCPF(cpf);
            ViewData["codNasc"] = verificaNasc(nasc);



            ViewData["nome"] = nome;
            ViewData["sobrenome"] = sobrenome;
            ViewData["cpf"] = cpf;
            ViewData["nasc"] = nasc;
            ViewData["idade"] = idade;
            ViewData["sexo"] = sexo;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

    }
}
