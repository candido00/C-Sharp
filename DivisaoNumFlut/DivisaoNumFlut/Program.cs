using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisaoNumFlut
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao();
            Console.ReadKey();
        }
        static void Divisao()
        {
            int teste;
            double calcDiv, num1, num2;

            Console.WriteLine("Informe quantos teste voce quer fazer: ");
            teste = int.Parse(Console.ReadLine());

            for (int i = 0; i < teste; i++)
            {
                Console.WriteLine("Informe o 1º numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o 2º numero: ");
                num2 = double.Parse(Console.ReadLine());

                if (num2 > 0)
                {
                    calcDiv = num1 / num2;
                    //Console.WriteLine("{0:C3}",calcDiv);
                    Console.WriteLine(calcDiv.ToString("F2"));

                }
                else if(num2 <= 0)
                {
                    Console.WriteLine("Impossível dividir!");
                }

                


            }

        }
    }
}
