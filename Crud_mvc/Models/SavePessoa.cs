using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_mvc.Models
{
    public class SavePessoa
    {
        const string caminho = @"C:/save.txt";

        public static void Criar()
        {
            string caminho = @"C:\doc\save.txt";
            File.Create(caminho);

        }
     
        public static void Salvar(string conteudo)
        {
            string caminho = @"C:\doc\save.txt";
            try
            {
                File.WriteAllText(caminho, conteudo);
                File.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            
        }
    }
}
