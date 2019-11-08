using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNomesPessoas
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
            string[] nomesPessoas = new string[3];

            for (int i = 0; i < nomesPessoas.Length; i++)
            {
                Console.WriteLine("Informe três nomes de pessoas: ");
                nomesPessoas[i] = Console.ReadLine();
            }
            foreach (var listarNomes in nomesPessoas)
            {
                Console.WriteLine("Nome: {0} " , listarNomes);
            }
            



        }
    }
}
