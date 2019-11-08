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
            int tamanho;
            string nomeProcurar;
            Console.WriteLine("Informe um tamanho para o Array: ");
            tamanho = Convert.ToInt32(Console.ReadLine());

            while (tamanho <= 0 || tamanho > 10)
            {
                Console.WriteLine("Informe um tamanho minimo (1) ou maximo (10)!!!");
                tamanho = Convert.ToInt32(Console.ReadLine());
            }
            string[] nomesAlturas = new string[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe um nome: ");
                nomesAlturas[i] = Console.ReadLine();
            }
            Console.WriteLine("Informe o nome que deseja acessar: ");
            nomeProcurar = Console.ReadLine();

            foreach (var listar in nomesAlturas)
            {
                if (nomeProcurar == listar)
                {
                    Console.WriteLine(nomeProcurar);
                }
                else
                {
                    Console.WriteLine("Nome nao consta nos dados armazenados!!");
                    break;
                }
                
            }
            
        }
    }
}
