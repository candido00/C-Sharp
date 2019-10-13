using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Validacao();
            Console.ReadKey();
        }
        static void Validacao()
        {
            int senha;

            Console.WriteLine("Informe a senha de acesso");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida!");
                senha = int.Parse(Console.ReadLine());

            }
            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
