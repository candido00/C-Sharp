using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Listar();
            Console.ReadKey();
        }
        static void Listar()
        {
            int idade;

            Console.WriteLine("Informe a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Não eleitor, ainda não sabe escolher os ladrões. :(");
            }
            else if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("Eleitor obrigatório, escolha o menos ladrão!! :)");
            }
            else if (idade >= 16 && idade < 18 || idade > 70)
            {
                Console.WriteLine("Eleitor facultativo, não vá votar!!");
            }
        }
    }
}
