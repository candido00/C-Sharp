using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNomesAlturas2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarAlturasNomes2();
            Console.ReadKey();
        }
        static void ListarAlturasNomes2()
        {
            string nome;
            string[,] nomesAlturas = new string[3,2];

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Console.WriteLine("Informe um valor: ");
                    nomesAlturas[i,x] = Console.ReadLine();

                }

            }
            //Console.WriteLine("Informe um nome para acessar a altura: ");
            //nome = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    //Console.WriteLine(nomesAlturas[i,x]);

                }

            }
            
        }
    }
}