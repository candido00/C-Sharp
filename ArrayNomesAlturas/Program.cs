using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNomesAlturas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarAlturasNomes();
            Console.ReadKey();
        }
        static void ListarAlturasNomes()
        {
            string nome;
            string [] nomesPessoas = new  string [3];
            double [] alturaPessoas = new double [3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe um nome: ");
                nomesPessoas[i] = Console.ReadLine();
                Console.WriteLine("Informe a altura: ");
                alturaPessoas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o nome pessoa para acessar altura: ");
            nome = Console.ReadLine();

            if (nome == nomesPessoas[0])
            {
                Console.WriteLine("Nome: " + nomesPessoas[0] + ", Altura: " + alturaPessoas[0].ToString("N2"));
            }
            else if (nome == nomesPessoas[1])
            {
                Console.WriteLine("Nome: " + nomesPessoas[1] + ", Altura: " + alturaPessoas[1].ToString("N2"));
            }
            else if (nome == nomesPessoas[2])
            {
                Console.WriteLine("Nome: " + nomesPessoas[2] + ", Altura: " + alturaPessoas[2].ToString("N2"));
            }
            else
            {
                Console.WriteLine("Nome não encontrado!!! :( ");
            }

        }
        
    }
}
