using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_mvc.Models
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public string cpf;
        public string nasc;
        public int idade;

        public Pessoa(string nome, string sobrenome, string cpf, string nasc, string idade)
        {
            setNome(nome);
            setSobrenome(sobrenome);
            setCPF(cpf);
            setNasc(nasc);
            setIdade(calcIdade(nasc));

        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            verificaNome(nome);
            this.nome = nome;

        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setSobrenome(string sobrenome)
        {
            verificaSobreome(sobrenome);
            this.sobrenome = sobrenome;

        }

        public string getCPF()
        {
            return this.cpf;
        }

        public void setCPF(string cpf)
        {
            verificaCPF(cpf);
            this.cpf = cpf;

        }

        public string getNasc()
        {
            return this.nasc;
        }

        public void setNasc(string nasc)
        {
            verificaNasc(nasc);
            this.nasc= nasc;

        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;

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
            }
            else if (contemNumeros(nome) == true)
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

            }
            else
            {
                return "Válido";
            }

        }

        public string verificaCPF(string cpf)
        {
            if (contemLetras(cpf) == true)
            {
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
            }
            else if (data.Year == ano && data.Month < mes)
            {
                valido = false;
            }
            else if (data.Year == ano && data.Month == mes && data.Day < dia)
            {
                valido = false;
            }
            else if (ano < (data.Year - 130))
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

        public int calcIdade(string nasc)
        {

            int idade = DateTime.Now.Year - Convert.ToInt32(nasc.Split('-')[2]);

            if (DateTime.Now.Month < Convert.ToInt32(nasc.Split('-')[1]))
            {
                idade--;
            }
            else if (DateTime.Now.Month == Convert.ToInt32(nasc.Split('-')[1]))
            {
                if (DateTime.Now.Day < Convert.ToInt32(nasc.Split('-')[0]))
                {
                    idade--;
                }
            }
            return idade;
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
