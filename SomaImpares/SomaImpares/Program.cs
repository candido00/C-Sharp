using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Console.ReadKey();

        }
        static void Soma()
        {
          
            int num1, num2,soma = 0;
            Console.WriteLine("Informe o 1º numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º numero: ");
            num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            for (int i = num2; i <= num1; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma dos impares no intervalo informado é: " + soma);


        }
    }
}
